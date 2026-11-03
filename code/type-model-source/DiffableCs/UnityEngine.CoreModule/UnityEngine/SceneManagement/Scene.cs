namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
[Token(Token = "0x200025E")]
public struct Scene
{
	[FieldOffset(Offset = "0x0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40007CE")]
	private SceneHandle m_Handle; //Field offset: 0x0

	[Token(Token = "0x17000392")]
	internal string guid
	{
		[Address(RVA = "0x3088580", Offset = "0x3087980", Length = "0xB")]
		[Token(Token = "0x6001850")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000391")]
	public SceneHandle handle
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x600184F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000394")]
	public bool isLoaded
	{
		[Address(RVA = "0x3088590", Offset = "0x3087990", Length = "0x35")]
		[Token(Token = "0x6001853")]
		 get { } //Length: 53
	}

	[Token(Token = "0x17000393")]
	public string name
	{
		[Address(RVA = "0x30885D0", Offset = "0x30879D0", Length = "0xB")]
		[Token(Token = "0x6001852")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000395")]
	public int rootCount
	{
		[Address(RVA = "0x30885E0", Offset = "0x30879E0", Length = "0x35")]
		[Token(Token = "0x6001854")]
		 get { } //Length: 53
	}

	[Address(RVA = "0x3087D70", Offset = "0x3087170", Length = "0x83")]
	[Token(Token = "0x6001859")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x3088580", Offset = "0x3087980", Length = "0xB")]
	[Token(Token = "0x6001850")]
	internal string get_guid() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x600184F")]
	public SceneHandle get_handle() { }

	[Address(RVA = "0x3088590", Offset = "0x3087990", Length = "0x35")]
	[Token(Token = "0x6001853")]
	public bool get_isLoaded() { }

	[Address(RVA = "0x30885D0", Offset = "0x30879D0", Length = "0xB")]
	[Token(Token = "0x6001852")]
	public string get_name() { }

	[Address(RVA = "0x30885E0", Offset = "0x30879E0", Length = "0x35")]
	[Token(Token = "0x6001854")]
	public int get_rootCount() { }

	[Address(RVA = "0x3087E50", Offset = "0x3087250", Length = "0x8B")]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600184B")]
	private static string GetGUIDInternal(SceneHandle sceneHandle) { }

	[Address(RVA = "0x3087E00", Offset = "0x3087200", Length = "0x42")]
	[Token(Token = "0x600185C")]
	private static void GetGUIDInternal_Injected(in SceneHandle sceneHandle, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3087EE0", Offset = "0x30872E0", Length = "0x9")]
	[Token(Token = "0x6001858")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3087F30", Offset = "0x3087330", Length = "0x33")]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600184C")]
	private static bool GetIsLoadedInternal(SceneHandle sceneHandle) { }

	[Address(RVA = "0x3087EF0", Offset = "0x30872F0", Length = "0x33")]
	[Token(Token = "0x600185D")]
	private static bool GetIsLoadedInternal_Injected(in SceneHandle sceneHandle) { }

	[Address(RVA = "0x3087FC0", Offset = "0x30873C0", Length = "0x8B")]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600184A")]
	private static string GetNameInternal(SceneHandle sceneHandle) { }

	[Address(RVA = "0x3087F70", Offset = "0x3087370", Length = "0x42")]
	[Token(Token = "0x600185B")]
	private static void GetNameInternal_Injected(in SceneHandle sceneHandle, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3088090", Offset = "0x3087490", Length = "0x33")]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600184D")]
	private static int GetRootCountInternal(SceneHandle sceneHandle) { }

	[Address(RVA = "0x3088050", Offset = "0x3087450", Length = "0x33")]
	[Token(Token = "0x600185E")]
	private static int GetRootCountInternal_Injected(in SceneHandle sceneHandle) { }

	[Address(RVA = "0x30883F0", Offset = "0x30877F0", Length = "0xCA")]
	[Token(Token = "0x6001855")]
	public GameObject[] GetRootGameObjects() { }

	[Address(RVA = "0x3088160", Offset = "0x3087560", Length = "0x287")]
	[Token(Token = "0x6001856")]
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	[Address(RVA = "0x3088120", Offset = "0x3087520", Length = "0x3B")]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600184E")]
	private static void GetRootGameObjectsInternal(SceneHandle sceneHandle, object resultRootList) { }

	[Address(RVA = "0x30880D0", Offset = "0x30874D0", Length = "0x42")]
	[Token(Token = "0x600185F")]
	private static void GetRootGameObjectsInternal_Injected(in SceneHandle sceneHandle, object resultRootList) { }

	[Address(RVA = "0x3088540", Offset = "0x3087940", Length = "0x35")]
	[Token(Token = "0x6001851")]
	public bool IsValid() { }

	[Address(RVA = "0x3088500", Offset = "0x3087900", Length = "0x33")]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6001849")]
	private static bool IsValidInternal(SceneHandle sceneHandle) { }

	[Address(RVA = "0x30884C0", Offset = "0x30878C0", Length = "0x33")]
	[Token(Token = "0x600185A")]
	private static bool IsValidInternal_Injected(in SceneHandle sceneHandle) { }

	[Address(RVA = "0x3088620", Offset = "0x3087A20", Length = "0xA")]
	[Token(Token = "0x6001857")]
	public static bool op_Equality(Scene lhs, Scene rhs) { }

}

