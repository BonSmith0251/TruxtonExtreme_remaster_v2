namespace UnityEngine.Timeline;

[Token(Token = "0x2000077")]
public interface IPropertyCollector
{

	[Token(Token = "0x6000356")]
	public void AddFromClip(AnimationClip clip) { }

	[Token(Token = "0x600035A")]
	public void AddFromClip(GameObject obj, AnimationClip clip) { }

	[Token(Token = "0x6000357")]
	public void AddFromClips(IEnumerable<AnimationClip> clips) { }

	[Token(Token = "0x600035B")]
	public void AddFromClips(GameObject obj, IEnumerable<AnimationClip> clips) { }

	[Token(Token = "0x600035F")]
	public void AddFromComponent(GameObject obj, Component component) { }

	[Token(Token = "0x6000358")]
	public void AddFromName(string name) { }

	[Token(Token = "0x6000359")]
	public void AddFromName(string name) { }

	[Token(Token = "0x600035C")]
	public void AddFromName(GameObject obj, string name) { }

	[Token(Token = "0x600035D")]
	public void AddFromName(GameObject obj, string name) { }

	[Token(Token = "0x600035E")]
	public void AddFromName(Component component, string name) { }

	[Token(Token = "0x6000360")]
	public void AddObjectProperties(object obj, AnimationClip clip) { }

	[Token(Token = "0x6000355")]
	public void PopActiveGameObject() { }

	[Token(Token = "0x6000354")]
	public void PushActiveGameObject(GameObject gameObject) { }

}

