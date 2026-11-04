using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// InGameManager.Get5000 0x1CE3F10 -> effect Score5000 (EffectScore5000, evidence/items/POPUPS.md): the "5000" plate plus
// "x" and the multiplier (shown from x2), at the source's screen point (GetSkyRootPosition, no offset), screen-fixed for
// 3.0 s. Plate: one billboard particle, startSize 52, size curve 2 -> 0.523 by 0.13 s then held (104 -> 27.2 units);
// alpha 0 -> 1 by 0.106 s, held to 2.47 s, 0 at 3.0 s. Digits (ProgressEffect 0x1D13B10): alpha in over 0.2 s, full to
// 2.0 s, linear out to 3.0 s; "x" at local x 10 (scale 5, 0.8-unit glyphs), digits at 13 and 16.5 (scale 6).
// Units are the sky play plane's (height Round1Sa01Motion.ViewHeight()); popups pause with the stage.
public sealed class Round1ScorePopups : MonoBehaviour
{
    const float Life=3,PlateStart=104,PlateRest=27.2f,PopTime=.13f,GlyphSize=.8f;
    sealed class Popup { public RectTransform root;public RawImage plate;public Image cross,tens,ones;public float age;public bool digits; }
    readonly List<Popup> live=new List<Popup>(),pool=new List<Popup>();
    Round1Weapon weapon;Canvas canvas;
    public int Shown { get; private set; }
    public int Active=>live.Count;

    public static void Show(Round1Weapon weapon,Vector2 viewport,int multiplier)
    {
        if(!Application.isPlaying || !weapon)return;
        var popups=weapon.GetComponent<Round1ScorePopups>();if(!popups){popups=weapon.gameObject.AddComponent<Round1ScorePopups>();popups.weapon=weapon;}
        popups.Spawn(viewport,multiplier);
    }
    public void Clear(){foreach(var p in live){p.root.gameObject.SetActive(false);pool.Add(p);}live.Clear();}
    static float Px(float units)=>units/Round1Sa01Motion.ViewHeight()*1080;
    void Spawn(Vector2 viewport,int multiplier)
    {
        var art=Round1ScorePopupArt.Current;if(!art || !art.plate)return;
        if(!canvas)
        {
            var go=new GameObject("Score popups");go.hideFlags=HideFlags.DontSave;go.transform.SetParent(transform,false);
            canvas=go.AddComponent<Canvas>();canvas.renderMode=RenderMode.ScreenSpaceOverlay;canvas.sortingOrder=5;
            var scaler=go.AddComponent<CanvasScaler>();scaler.uiScaleMode=CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution=new Vector2(1920,1080);scaler.matchWidthOrHeight=1;
        }
        Popup p;
        if(pool.Count>0){p=pool[pool.Count-1];pool.RemoveAt(pool.Count-1);}
        else
        {
            p=new Popup{root=new GameObject("5000",typeof(RectTransform)).GetComponent<RectTransform>()};p.root.SetParent(canvas.transform,false);
            p.plate=new GameObject("plate",typeof(RectTransform)).AddComponent<RawImage>();p.plate.rectTransform.SetParent(p.root,false);p.plate.texture=art.plate;
            p.cross=Glyph(p.root,"x",art.cross,10,5);p.tens=Glyph(p.root,"sprite10",null,13,6);p.ones=Glyph(p.root,"sprite00",null,16.5f,6);
            foreach(var g in p.root.GetComponentsInChildren<Graphic>())g.raycastTarget=false;
        }
        p.root.anchorMin=p.root.anchorMax=viewport;p.root.anchoredPosition=Vector2.zero;p.root.SetAsLastSibling();p.age=0;
        // PlayStartEffect 0x1D13870: n < 2 hides the multiplier; else n = min(n, 99), sprite10 = tens or ones, sprite00 = ones.
        p.digits=multiplier>=2;int n=Mathf.Min(multiplier,99),tens=n/10,ones=n%10;
        if(art.digits!=null && art.digits.Length==10){p.tens.sprite=art.digits[tens>0?tens:ones];p.ones.sprite=art.digits[ones];}
        p.cross.gameObject.SetActive(p.digits);p.tens.gameObject.SetActive(p.digits);p.ones.gameObject.SetActive(p.digits && tens>0);
        p.root.gameObject.SetActive(true);live.Add(p);Shown++;Animate(p);
    }
    static Image Glyph(RectTransform parent,string name,Sprite sprite,float x,float scale)
    {
        var image=new GameObject(name,typeof(RectTransform)).AddComponent<Image>();var rt=image.rectTransform;rt.SetParent(parent,false);
        image.sprite=sprite;image.preserveAspect=true;rt.sizeDelta=Vector2.one*Px(GlyphSize*scale);rt.anchoredPosition=new Vector2(Px(x),0);return image;
    }
    void LateUpdate()
    {
        if(live.Count==0)return;
        bool running=!weapon || !weapon.player || !weapon.player.playback || weapon.player.playback.playing || weapon.GameOver || weapon.RoundCleared;
        float dt=running?Time.deltaTime:0;
        for(int i=live.Count-1;i>=0;i--)
        {
            var p=live[i];p.age+=dt;
            if(p.age>=Life){p.root.gameObject.SetActive(false);live.RemoveAt(i);pool.Add(p);continue;}
            Animate(p);
        }
    }
    static void Animate(Popup p)
    {
        float e=p.age,u=e/Life;
        float size=e<PopTime?Mathf.Lerp(PlateStart,PlateRest,e/PopTime):PlateRest;
        float plateAlpha=u<.0353f?u/.0353f:u<.8235f?1:Mathf.Clamp01(1-(u-.8235f)/(1-.8235f));
        p.plate.rectTransform.sizeDelta=Vector2.one*Px(size);p.plate.color=new Color(1,1,1,plateAlpha);
        float t=Life-e,digitAlpha=t>=2.8f?1-(t-2.8f)/.2f:Mathf.Clamp01(t);var c=new Color(1,1,1,digitAlpha);
        p.cross.color=c;p.tens.color=c;p.ones.color=c;
    }
}
