namespace KANAI.Popup;

[Token(Token = "0x2000023")]
public class PopupManager : MonoBehaviourSingleton<PopupManager>
{
	[CompilerGenerated]
	[Token(Token = "0x2000028")]
	private sealed class <_CreatePopupPrefabAsync>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CA")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000CB")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000CC")]
		public PopupManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000CD")]
		public string prefabName; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000CE")]
		private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000CF")]
		public bool withName; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000D0")]
		public Action<GameObject> tcallback; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000D1")]
		private AsyncInstantiateOperation<GameObject> <op>5__2; //Field offset: 0x48

		[Token(Token = "0x17000031")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000121")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000032")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000123")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600011E")]
		public <_CreatePopupPrefabAsync>d__15(int <>1__state) { }

		[Address(RVA = "0x1E0E970", Offset = "0x1E0DD70", Length = "0x2C5")]
		[Token(Token = "0x6000120")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000121")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000123")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0EC40", Offset = "0x1E0E040", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000122")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600011F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private sealed class <_resourceLoadAsync>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D2")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000D3")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000D4")]
		public string snamepath; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000D5")]
		public PopupManager <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000D6")]
		public Action<GameObject> callback; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000D7")]
		private string <keyName>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000D8")]
		private ResourceRequest <tload>5__3; //Field offset: 0x40

		[Token(Token = "0x17000033")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000127")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000034")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000129")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000124")]
		public <_resourceLoadAsync>d__18(int <>1__state) { }

		[Address(RVA = "0x1E0EF20", Offset = "0x1E0E320", Length = "0x1EE")]
		[Token(Token = "0x6000126")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000127")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000129")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0F110", Offset = "0x1E0E510", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000128")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000125")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000024")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B9")]
		public GameObject windowObject; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000BA")]
		public GameObject contentObject; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600010D")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x600010E")]
		internal void <ShowCommonPopupAsync>b__0(GameObject wobj) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600010F")]
		internal void <ShowCommonPopupAsync>b__1(GameObject tobj) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BB")]
		public GameObject tobj; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000110")]
		public <>c__DisplayClass15_0() { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000111")]
		internal void <_CreatePopupPrefabAsync>b__0(GameObject createObj) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000026")]
	private sealed class <ShowCommonPopupAsync>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BC")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BD")]
		private object <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BE")]
		public PopupManager <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BF")]
		public CommonPopupParam iParam; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C0")]
		public Func<Int32, Boolean> iOnHiddenCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C1")]
		public Action<PopupBase, PopupContentBase> iOnCreateCallback; //Field offset: 0x0

		[Token(Token = "0x1700002D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000115")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700002E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000117")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000112")]
		public <ShowCommonPopupAsync>d__10`1(int <>1__state) { }

		[Address(RVA = "0x19D7D80", Offset = "0x19D7180", Length = "0xDF")]
		[Token(Token = "0x6000114")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000115")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000117")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000116")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000113")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000027")]
	private sealed class <ShowCommonPopupAsync>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000C2")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000C3")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000C4")]
		public PopupManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000C5")]
		public string tname; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000C6")]
		private <>c__DisplayClass11_0 <>8__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000C7")]
		public CommonPopupParam iParam; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000C8")]
		public Func<Int32, Boolean> iOnHiddenCallback; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000C9")]
		public Action<PopupBase, PopupContentBase> iOnCreateCallback; //Field offset: 0x48

		[Token(Token = "0x1700002F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600011B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000030")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600011D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000118")]
		public <ShowCommonPopupAsync>d__11(int <>1__state) { }

		[Address(RVA = "0x1E0E140", Offset = "0x1E0D540", Length = "0x274")]
		[Token(Token = "0x600011A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600011B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600011D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0E3C0", Offset = "0x1E0D7C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600011C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000119")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B6")]
	private string _defaultPopup; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000B7")]
	private PopupSystem _attachedSystem; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000B8")]
	private Dictionary<String, GameObject> _cacheObjects; //Field offset: 0x30

	[Token(Token = "0x1700002C")]
	public bool IsReadyToUse
	{
		[Address(RVA = "0x1E0A440", Offset = "0x1E09840", Length = "0x16")]
		[Token(Token = "0x600010B")]
		 get { } //Length: 22
	}

	[Address(RVA = "0x1E09AA0", Offset = "0x1E08EA0", Length = "0x200")]
	[Token(Token = "0x6000106")]
	private GameObject _CreatePopupPrefab(string prefabName, bool withName = false) { }

	[Address(RVA = "0x1E099E0", Offset = "0x1E08DE0", Length = "0xB5")]
	[IteratorStateMachine(typeof(<_CreatePopupPrefabAsync>d__15))]
	[Token(Token = "0x6000107")]
	private IEnumerator _CreatePopupPrefabAsync(string prefabName, bool withName, Action<GameObject> tcallback) { }

	[Address(RVA = "0x1E09D60", Offset = "0x1E09160", Length = "0x384")]
	[Token(Token = "0x6000104")]
	private PopupBase _entryPopup(CommonPopupParam iParam, Func<Int32, Boolean> iOnHiddenCallback, GameObject window, GameObject contentObject) { }

	[Address(RVA = "0x1E0A100", Offset = "0x1E09500", Length = "0x178")]
	[Token(Token = "0x6000108")]
	private List<PopupButtonInfo> _getCommonButtonList(PopupButtonOrder iOrder) { }

	[Address(RVA = "0x1E0A340", Offset = "0x1E09740", Length = "0xF5")]
	[Token(Token = "0x6000109")]
	private GameObject _resourceLoad(string snamepath) { }

	[Address(RVA = "0x1E0A290", Offset = "0x1E09690", Length = "0xA1")]
	[IteratorStateMachine(typeof(<_resourceLoadAsync>d__18))]
	[Token(Token = "0x600010A")]
	private IEnumerator _resourceLoadAsync(string snamepath, Action<GameObject> callback) { }

	[Address(RVA = "0x1E09CB0", Offset = "0x1E090B0", Length = "0xA6")]
	[Token(Token = "0x600010C")]
	public PopupManager() { }

	[Address(RVA = "0x1E09310", Offset = "0x1E08710", Length = "0x8E")]
	[Token(Token = "0x60000F9")]
	public void AttachedObject(GameObject tobj, string objPath) { }

	[Address(RVA = "0x1E093A0", Offset = "0x1E087A0", Length = "0x7E")]
	[Token(Token = "0x60000FA")]
	public void DetachedObject(string objPath) { }

	[Address(RVA = "0x1E0A440", Offset = "0x1E09840", Length = "0x16")]
	[Token(Token = "0x600010B")]
	public bool get_IsReadyToUse() { }

	[Address(RVA = "0x1E09420", Offset = "0x1E08820", Length = "0xE6")]
	[Token(Token = "0x6000105")]
	public static string GetStringByKey(string s) { }

	[Address(RVA = "0x1E09510", Offset = "0x1E08910", Length = "0x64")]
	[Token(Token = "0x60000F8")]
	public void Initialize(PopupSystem iSystem = null) { }

	[Address(RVA = "0x1E09580", Offset = "0x1E08980", Length = "0x89")]
	[Token(Token = "0x60000FD")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60000FB")]
	public void SetDefaultPopup(string v) { }

	[Address(RVA = "0x8B31C0", Offset = "0x8B25C0", Length = "0x177")]
	[Token(Token = "0x6000101")]
	public ValueTuple<PopupBase, T> ShowCommonPopup(CommonPopupParam iParam, Func<Int32, Boolean> iOnHiddenCallback = null) { }

	[Address(RVA = "0x1E09610", Offset = "0x1E08A10", Length = "0xD2")]
	[IteratorStateMachine(typeof(<ShowCommonPopupAsync>d__11))]
	[Token(Token = "0x6000103")]
	public IEnumerator ShowCommonPopupAsync(string tname, CommonPopupParam iParam, Func<Int32, Boolean> iOnHiddenCallback, Action<PopupBase, PopupContentBase> iOnCreateCallback) { }

	[Address(RVA = "0x8B30E0", Offset = "0x8B24E0", Length = "0xD3")]
	[IteratorStateMachine(typeof(<ShowCommonPopupAsync>d__10`1))]
	[Token(Token = "0x6000102")]
	public IEnumerator ShowCommonPopupAsync(CommonPopupParam iParam, Func<Int32, Boolean> iOnHiddenCallback, Action<PopupBase, PopupContentBase> iOnCreateCallback) { }

	[Address(RVA = "0x1E096F0", Offset = "0x1E08AF0", Length = "0xFB")]
	[Token(Token = "0x6000100")]
	public PopupBase ShowErrorPopup(string iMessage, Func<Int32, Boolean> iOnHiddenCallback = null) { }

	[Address(RVA = "0x1E097F0", Offset = "0x1E08BF0", Length = "0x7B")]
	[Token(Token = "0x60000FF")]
	public ValueTuple<PopupBase, MessagePopupContent> ShowMessagePopup(CommonPopupParam iParam, Func<Int32, Boolean> iOnHiddenCallback = null) { }

	[Address(RVA = "0x1E09870", Offset = "0x1E08C70", Length = "0x103")]
	[Token(Token = "0x60000FE")]
	public ValueTuple<PopupBase, MessagePopupContent> ShowMessagePopup(PopupSizeType iWindowSize, PopupButtonOrder iButtonOrder, string iTitle, string iMessage, Func<Int32, Boolean> iOnHiddenCallback = null, int iPriority = 100) { }

	[Address(RVA = "0x1E09980", Offset = "0x1E08D80", Length = "0x5E")]
	[Token(Token = "0x60000FC")]
	public void Terminate() { }

}

