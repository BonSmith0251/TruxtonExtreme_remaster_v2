namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x200005E")]
public struct SceneInstance
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000105")]
	private Scene m_Scene; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000106")]
	private bool m_ReleaseOnSceneUnloaded; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000107")]
	internal AsyncOperation m_Operation; //Field offset: 0x8

	[Token(Token = "0x17000059")]
	internal bool ReleaseSceneOnSceneUnloaded
	{
		[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
		[Token(Token = "0x600021F")]
		internal get { } //Length: 5
		[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
		[Token(Token = "0x6000220")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000058")]
	public internal Scene Scene
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x600021D")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x600021E")]
		internal set { } //Length: 3
	}

	[Address(RVA = "0x2E4DD30", Offset = "0x2E4D130", Length = "0x2B")]
	[Token(Token = "0x6000221")]
	public AsyncOperation ActivateAsync() { }

	[Address(RVA = "0x2E4DD60", Offset = "0x2E4D160", Length = "0xBB")]
	[Token(Token = "0x6000223")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
	[Token(Token = "0x600021F")]
	internal bool get_ReleaseSceneOnSceneUnloaded() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x600021D")]
	public Scene get_Scene() { }

	[Address(RVA = "0x2E4DE20", Offset = "0x2E4D220", Length = "0x1B")]
	[Token(Token = "0x6000222")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
	[Token(Token = "0x6000220")]
	internal void set_ReleaseSceneOnSceneUnloaded(bool value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600021E")]
	internal void set_Scene(Scene value) { }

}

