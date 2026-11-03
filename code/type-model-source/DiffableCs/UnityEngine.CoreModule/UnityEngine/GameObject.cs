namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[Token(Token = "0x20001AF")]
[UsedByNativeCode]
public sealed class GameObject : object
{

	[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
	[Token(Token = "0x170002E2")]
	public bool active
	{
		[Address(RVA = "0x3064AF0", Offset = "0x3063EF0", Length = "0x76")]
		[NativeMethod(Name = "IsActive")]
		[Token(Token = "0x6001350")]
		 get { } //Length: 118
		[Address(RVA = "0x30652C0", Offset = "0x30646C0", Length = "0x86")]
		[NativeMethod(Name = "SetSelfActive")]
		[Token(Token = "0x6001351")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170002E4")]
	public bool activeInHierarchy
	{
		[Address(RVA = "0x3064970", Offset = "0x3063D70", Length = "0x76")]
		[NativeMethod(Name = "IsActive")]
		[Token(Token = "0x6001354")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170002E3")]
	public bool activeSelf
	{
		[Address(RVA = "0x3064A30", Offset = "0x3063E30", Length = "0x76")]
		[NativeMethod(Name = "IsSelfActive")]
		[Token(Token = "0x6001353")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170002EA")]
	public GameObject gameObject
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x600137C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170002E5")]
	public bool isStatic
	{
		[Address(RVA = "0x3064C70", Offset = "0x3064070", Length = "0x76")]
		[NativeMethod(Name = "GetIsStaticDeprecated")]
		[Token(Token = "0x6001356")]
		 get { } //Length: 118
		[Address(RVA = "0x30653A0", Offset = "0x30647A0", Length = "0x86")]
		[NativeMethod(Name = "SetIsStaticDeprecated")]
		[Token(Token = "0x6001357")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170002E6")]
	internal bool isStaticBatchable
	{
		[Address(RVA = "0x3064BB0", Offset = "0x3063FB0", Length = "0x76")]
		[NativeMethod(Name = "IsStaticBatchable")]
		[Token(Token = "0x6001358")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x170002E1")]
	public int layer
	{
		[Address(RVA = "0x3064D30", Offset = "0x3064130", Length = "0x76")]
		[Token(Token = "0x600134E")]
		 get { } //Length: 118
		[Address(RVA = "0x3065470", Offset = "0x3064870", Length = "0x83")]
		[Token(Token = "0x600134F")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170002E8")]
	public Scene scene
	{
		[Address(RVA = "0x3064EC0", Offset = "0x30642C0", Length = "0x87")]
		[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
		[Token(Token = "0x600137A")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170002E9")]
	public ulong sceneCullingMask
	{
		[Address(RVA = "0x3064DF0", Offset = "0x30641F0", Length = "0x76")]
		[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
		[Token(Token = "0x600137B")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170002E7")]
	public string tag
	{
		[Address(RVA = "0x3064FA0", Offset = "0x30643A0", Length = "0x106")]
		[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
		[Token(Token = "0x6001359")]
		 get { } //Length: 262
		[Address(RVA = "0x3065550", Offset = "0x3064950", Length = "0x1C7")]
		[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
		[Token(Token = "0x600135A")]
		 set { } //Length: 455
	}

	[Token(Token = "0x170002DF")]
	public Transform transform
	{
		[Address(RVA = "0x30651D0", Offset = "0x30645D0", Length = "0x90")]
		[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
		[Token(Token = "0x600134C")]
		 get { } //Length: 144
	}

	[Token(Token = "0x170002E0")]
	public TransformHandle transformHandle
	{
		[Address(RVA = "0x3065100", Offset = "0x3064500", Length = "0x8E")]
		[FreeFunction("GameObjectBindings::GetTransformHandle", HasExplicitThis = True)]
		[Token(Token = "0x600134D")]
		 get { } //Length: 142
	}

	[Address(RVA = "0x3064720", Offset = "0x3063B20", Length = "0x63")]
	[Token(Token = "0x600136A")]
	public GameObject(string name) { }

	[Address(RVA = "0x30648D0", Offset = "0x3063CD0", Length = "0x56")]
	[Token(Token = "0x600136B")]
	public GameObject() { }

	[Address(RVA = "0x3064790", Offset = "0x3063B90", Length = "0x13A")]
	[Token(Token = "0x600136C")]
	public GameObject(string name, Type[] components) { }

	[Address(RVA = "0x3060B00", Offset = "0x305FF00", Length = "0x9F")]
	[Token(Token = "0x6001345")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component AddComponent(Type componentType) { }

	[Address(RVA = "0x812700", Offset = "0x811B00", Length = "0x8E")]
	[Token(Token = "0x6001346")]
	public T AddComponent() { }

	[Address(RVA = "0x30608E0", Offset = "0x305FCE0", Length = "0x214")]
	[FreeFunction(Name = "MonoAddComponent", HasExplicitThis = True)]
	[Token(Token = "0x6001343")]
	internal Component AddComponentInternal(string className) { }

	[Address(RVA = "0x3060890", Offset = "0x305FC90", Length = "0x42")]
	[Token(Token = "0x6001388")]
	private static IntPtr AddComponentInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper className) { }

	[Address(RVA = "0x3060C30", Offset = "0x3060030", Length = "0x1D")]
	[Token(Token = "0x6001342")]
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[Address(RVA = "0x3060C50", Offset = "0x3060050", Length = "0x1DB")]
	[FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = True)]
	[Token(Token = "0x6001367")]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[Address(RVA = "0x3060C10", Offset = "0x3060010", Length = "0x1A")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001368")]
	public void BroadcastMessage(string methodName, object parameter) { }

	[Address(RVA = "0x3060E30", Offset = "0x3060230", Length = "0x1D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001369")]
	public void BroadcastMessage(string methodName) { }

	[Address(RVA = "0x3060BA0", Offset = "0x305FFA0", Length = "0x62")]
	[Token(Token = "0x60013A2")]
	private static void BroadcastMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object parameter, SendMessageOptions options) { }

	[Address(RVA = "0x3061140", Offset = "0x3060540", Length = "0x8")]
	[Token(Token = "0x600135B")]
	public bool CompareTag(string tag) { }

	[Address(RVA = "0x3061150", Offset = "0x3060550", Length = "0x7F")]
	[Token(Token = "0x600135C")]
	public bool CompareTag(TagHandle tag) { }

	[Address(RVA = "0x3060F70", Offset = "0x3060370", Length = "0x1CE")]
	[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = True)]
	[Token(Token = "0x600135D")]
	private bool CompareTag_Internal(string tag) { }

	[Address(RVA = "0x3060F20", Offset = "0x3060320", Length = "0x42")]
	[Token(Token = "0x600139C")]
	private static bool CompareTag_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper tag) { }

	[Address(RVA = "0x3060EA0", Offset = "0x30602A0", Length = "0x7E")]
	[FreeFunction(Name = "GameObjectBindings::CompareTagHandle", HasExplicitThis = True)]
	[Token(Token = "0x600135E")]
	private bool CompareTagHandle_Internal(TagHandle tag) { }

	[Address(RVA = "0x3060E50", Offset = "0x3060250", Length = "0x42")]
	[Token(Token = "0x600139D")]
	private static bool CompareTagHandle_Internal_Injected(IntPtr _unity_self, in TagHandle tag) { }

	[Address(RVA = "0x3061210", Offset = "0x3060610", Length = "0x5B")]
	[FreeFunction("GameObjectBindings::CreatePrimitive")]
	[Token(Token = "0x600131A")]
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	[Address(RVA = "0x30611D0", Offset = "0x30605D0", Length = "0x31")]
	[Token(Token = "0x600137D")]
	private static IntPtr CreatePrimitive_Injected(PrimitiveType type) { }

	[Address(RVA = "0x30618A0", Offset = "0x3060CA0", Length = "0x1DA")]
	[FreeFunction(Name = "GameObjectBindings::Find")]
	[Token(Token = "0x600136E")]
	public static GameObject Find(string name) { }

	[Address(RVA = "0x3061860", Offset = "0x3060C60", Length = "0x33")]
	[Token(Token = "0x60013A4")]
	private static IntPtr Find_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x30616B0", Offset = "0x3060AB0", Length = "0x8")]
	[Token(Token = "0x600133F")]
	public static void FindGameObjectsWithTag(string tag, List<GameObject> results) { }

	[Address(RVA = "0x30616C0", Offset = "0x3060AC0", Length = "0x18F")]
	[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = True)]
	[Token(Token = "0x6001360")]
	public static GameObject[] FindGameObjectsWithTag(string tag) { }

	[Address(RVA = "0x3061670", Offset = "0x3060A70", Length = "0x33")]
	[Token(Token = "0x600139F")]
	private static GameObject[] FindGameObjectsWithTag_Injected(ref ManagedSpanWrapper tag) { }

	[Address(RVA = "0x30614E0", Offset = "0x30608E0", Length = "0x187")]
	[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTagForListInternal", ThrowsException = True)]
	[Token(Token = "0x600133E")]
	private static void FindGameObjectsWithTagForListInternal(string tag, object results) { }

	[Address(RVA = "0x3061490", Offset = "0x3060890", Length = "0x42")]
	[Token(Token = "0x6001387")]
	private static void FindGameObjectsWithTagForListInternal_Injected(ref ManagedSpanWrapper tag, object results) { }

	[Address(RVA = "0x30612B0", Offset = "0x30606B0", Length = "0x1DA")]
	[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = True)]
	[Token(Token = "0x600135F")]
	public static GameObject FindGameObjectWithTag(string tag) { }

	[Address(RVA = "0x3061270", Offset = "0x3060670", Length = "0x33")]
	[Token(Token = "0x600139E")]
	private static IntPtr FindGameObjectWithTag_Injected(ref ManagedSpanWrapper tag) { }

	[Address(RVA = "0x3061850", Offset = "0x3060C50", Length = "0x9")]
	[Token(Token = "0x600133D")]
	public static GameObject FindWithTag(string tag) { }

	[Address(RVA = "0x3064AF0", Offset = "0x3063EF0", Length = "0x76")]
	[NativeMethod(Name = "IsActive")]
	[Token(Token = "0x6001350")]
	public bool get_active() { }

	[Address(RVA = "0x3064AB0", Offset = "0x3063EB0", Length = "0x33")]
	[Token(Token = "0x6001391")]
	private static bool get_active_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3064970", Offset = "0x3063D70", Length = "0x76")]
	[NativeMethod(Name = "IsActive")]
	[Token(Token = "0x6001354")]
	public bool get_activeInHierarchy() { }

	[Address(RVA = "0x3064930", Offset = "0x3063D30", Length = "0x33")]
	[Token(Token = "0x6001395")]
	private static bool get_activeInHierarchy_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3064A30", Offset = "0x3063E30", Length = "0x76")]
	[NativeMethod(Name = "IsSelfActive")]
	[Token(Token = "0x6001353")]
	public bool get_activeSelf() { }

	[Address(RVA = "0x30649F0", Offset = "0x3063DF0", Length = "0x33")]
	[Token(Token = "0x6001394")]
	private static bool get_activeSelf_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x600137C")]
	public GameObject get_gameObject() { }

	[Address(RVA = "0x3064C70", Offset = "0x3064070", Length = "0x76")]
	[NativeMethod(Name = "GetIsStaticDeprecated")]
	[Token(Token = "0x6001356")]
	public bool get_isStatic() { }

	[Address(RVA = "0x3064C30", Offset = "0x3064030", Length = "0x33")]
	[Token(Token = "0x6001397")]
	private static bool get_isStatic_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3064BB0", Offset = "0x3063FB0", Length = "0x76")]
	[NativeMethod(Name = "IsStaticBatchable")]
	[Token(Token = "0x6001358")]
	internal bool get_isStaticBatchable() { }

	[Address(RVA = "0x3064B70", Offset = "0x3063F70", Length = "0x33")]
	[Token(Token = "0x6001399")]
	private static bool get_isStaticBatchable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3064D30", Offset = "0x3064130", Length = "0x76")]
	[Token(Token = "0x600134E")]
	public int get_layer() { }

	[Address(RVA = "0x3064CF0", Offset = "0x30640F0", Length = "0x33")]
	[Token(Token = "0x600138F")]
	private static int get_layer_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3064EC0", Offset = "0x30642C0", Length = "0x87")]
	[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
	[Token(Token = "0x600137A")]
	public Scene get_scene() { }

	[Address(RVA = "0x3064E70", Offset = "0x3064270", Length = "0x42")]
	[Token(Token = "0x60013A7")]
	private static void get_scene_Injected(IntPtr _unity_self, out Scene ret) { }

	[Address(RVA = "0x3064DF0", Offset = "0x30641F0", Length = "0x76")]
	[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
	[Token(Token = "0x600137B")]
	public ulong get_sceneCullingMask() { }

	[Address(RVA = "0x3064DB0", Offset = "0x30641B0", Length = "0x33")]
	[Token(Token = "0x60013A8")]
	private static ulong get_sceneCullingMask_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3064FA0", Offset = "0x30643A0", Length = "0x106")]
	[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
	[Token(Token = "0x6001359")]
	public string get_tag() { }

	[Address(RVA = "0x3064F50", Offset = "0x3064350", Length = "0x42")]
	[Token(Token = "0x600139A")]
	private static void get_tag_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30651D0", Offset = "0x30645D0", Length = "0x90")]
	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	[Token(Token = "0x600134C")]
	public Transform get_transform() { }

	[Address(RVA = "0x3065190", Offset = "0x3064590", Length = "0x33")]
	[Token(Token = "0x600138D")]
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3065100", Offset = "0x3064500", Length = "0x8E")]
	[FreeFunction("GameObjectBindings::GetTransformHandle", HasExplicitThis = True)]
	[Token(Token = "0x600134D")]
	public TransformHandle get_transformHandle() { }

	[Address(RVA = "0x30650B0", Offset = "0x30644B0", Length = "0x42")]
	[Token(Token = "0x600138E")]
	private static void get_transformHandle_Injected(IntPtr _unity_self, out TransformHandle ret) { }

	[Address(RVA = "0x813130", Offset = "0x812530", Length = "0x71")]
	[Token(Token = "0x600131B")]
	public T GetComponent() { }

	[Address(RVA = "0x30627B0", Offset = "0x3061BB0", Length = "0x9F")]
	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600131C")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[Address(RVA = "0x30627A0", Offset = "0x3061BA0", Length = "0xA")]
	[Token(Token = "0x6001320")]
	public Component GetComponent(string type) { }

	[Address(RVA = "0x3062750", Offset = "0x3061B50", Length = "0x42")]
	[Token(Token = "0x600137E")]
	private static IntPtr GetComponent_Injected(IntPtr _unity_self, Type type) { }

	[Address(RVA = "0x3061A80", Offset = "0x3060E80", Length = "0x15B")]
	[Token(Token = "0x6001349")]
	public Component GetComponentAtIndex(int index) { }

	[Address(RVA = "0x812790", Offset = "0x811B90", Length = "0xFB")]
	[Token(Token = "0x600134A")]
	public T GetComponentAtIndex(int index) { }

	[Address(RVA = "0x3061EC0", Offset = "0x30612C0", Length = "0x214")]
	[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObject", HasExplicitThis = True)]
	[Token(Token = "0x600131E")]
	internal Component GetComponentByName(string type) { }

	[Address(RVA = "0x3061E70", Offset = "0x3061270", Length = "0x42")]
	[Token(Token = "0x6001380")]
	private static IntPtr GetComponentByName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper type) { }

	[Address(RVA = "0x3061C40", Offset = "0x3061040", Length = "0x221")]
	[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObjectWithCase", HasExplicitThis = True)]
	[Token(Token = "0x600131F")]
	internal Component GetComponentByNameWithCase(string type, bool caseSensitive) { }

	[Address(RVA = "0x3061BE0", Offset = "0x3060FE0", Length = "0x54")]
	[Token(Token = "0x6001381")]
	private static IntPtr GetComponentByNameWithCase_Injected(IntPtr _unity_self, ref ManagedSpanWrapper type, bool caseSensitive) { }

	[Address(RVA = "0x3062120", Offset = "0x3061520", Length = "0x76")]
	[Token(Token = "0x6001347")]
	public int GetComponentCount() { }

	[Address(RVA = "0x30620E0", Offset = "0x30614E0", Length = "0x33")]
	[Token(Token = "0x600138A")]
	private static int GetComponentCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3062200", Offset = "0x3061600", Length = "0x95")]
	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600131D")]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[Address(RVA = "0x30621A0", Offset = "0x30615A0", Length = "0x52")]
	[Token(Token = "0x600137F")]
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	[Address(RVA = "0x812BC0", Offset = "0x811FC0", Length = "0xBA")]
	[Token(Token = "0x6001324")]
	public T GetComponentInChildren(bool includeInactive) { }

	[Address(RVA = "0x812AF0", Offset = "0x811EF0", Length = "0xC2")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001323")]
	public T GetComponentInChildren() { }

	[Address(RVA = "0x3062300", Offset = "0x3061700", Length = "0xA2")]
	[Token(Token = "0x6001322")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type type) { }

	[Address(RVA = "0x30623B0", Offset = "0x30617B0", Length = "0xB1")]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001321")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[Address(RVA = "0x30622A0", Offset = "0x30616A0", Length = "0x54")]
	[Token(Token = "0x6001382")]
	private static IntPtr GetComponentInChildren_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	[Address(RVA = "0x3062690", Offset = "0x3061A90", Length = "0xBA")]
	[Token(Token = "0x600134B")]
	public int GetComponentIndex(Component component) { }

	[Address(RVA = "0x3062640", Offset = "0x3061A40", Length = "0x42")]
	[Token(Token = "0x600138C")]
	private static int GetComponentIndex_Injected(IntPtr _unity_self, IntPtr component) { }

	[Address(RVA = "0x30624D0", Offset = "0x30618D0", Length = "0xB1")]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001325")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[Address(RVA = "0x812E90", Offset = "0x812290", Length = "0xC2")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001327")]
	public T GetComponentInParent() { }

	[Address(RVA = "0x3062590", Offset = "0x3061990", Length = "0xA2")]
	[Token(Token = "0x6001326")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type type) { }

	[Address(RVA = "0x812DD0", Offset = "0x8121D0", Length = "0xBA")]
	[Token(Token = "0x6001328")]
	public T GetComponentInParent(bool includeInactive) { }

	[Address(RVA = "0x3062470", Offset = "0x3061870", Length = "0x54")]
	[Token(Token = "0x6001383")]
	private static IntPtr GetComponentInParent_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	[Address(RVA = "0x3062E60", Offset = "0x3062260", Length = "0xF8")]
	[Token(Token = "0x600132A")]
	public Component[] GetComponents(Type type) { }

	[Address(RVA = "0x813660", Offset = "0x812A60", Length = "0x86")]
	[Token(Token = "0x600132D")]
	public void GetComponents(List<T> results) { }

	[Address(RVA = "0x8136F0", Offset = "0x812AF0", Length = "0xD0")]
	[Token(Token = "0x600132B")]
	public T[] GetComponents() { }

	[Address(RVA = "0x3062DB0", Offset = "0x30621B0", Length = "0xA7")]
	[Token(Token = "0x600132C")]
	public void GetComponents(Type type, List<Component> results) { }

	[Address(RVA = "0x3062960", Offset = "0x3061D60", Length = "0xF7")]
	[ExcludeFromDocs]
	[Token(Token = "0x600132E")]
	public Component[] GetComponentsInChildren(Type type) { }

	[Address(RVA = "0x813250", Offset = "0x812650", Length = "0xE0")]
	[Token(Token = "0x6001330")]
	public T[] GetComponentsInChildren(bool includeInactive) { }

	[Address(RVA = "0x8131B0", Offset = "0x8125B0", Length = "0x94")]
	[Token(Token = "0x6001331")]
	public void GetComponentsInChildren(bool includeInactive, List<T> results) { }

	[Address(RVA = "0x8133E0", Offset = "0x8127E0", Length = "0xE7")]
	[Token(Token = "0x6001332")]
	public T[] GetComponentsInChildren() { }

	[Address(RVA = "0x3062850", Offset = "0x3061C50", Length = "0x108")]
	[Token(Token = "0x600132F")]
	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	[Address(RVA = "0x813340", Offset = "0x812740", Length = "0x9E")]
	[Token(Token = "0x6001333")]
	public void GetComponentsInChildren(List<T> results) { }

	[Address(RVA = "0x3062A60", Offset = "0x3061E60", Length = "0xF8")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001334")]
	public Component[] GetComponentsInParent(Type type) { }

	[Address(RVA = "0x3062B60", Offset = "0x3061F60", Length = "0x109")]
	[Token(Token = "0x6001335")]
	public Component[] GetComponentsInParent(Type type, bool includeInactive) { }

	[Address(RVA = "0x8135C0", Offset = "0x8129C0", Length = "0x94")]
	[Token(Token = "0x6001336")]
	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	[Address(RVA = "0x8134D0", Offset = "0x8128D0", Length = "0xE0")]
	[Token(Token = "0x6001337")]
	public T[] GetComponentsInParent(bool includeInactive) { }

	[Address(RVA = "0x7A66B0", Offset = "0x7A5AB0", Length = "0x3E")]
	[Token(Token = "0x6001338")]
	public T[] GetComponentsInParent() { }

	[Address(RVA = "0x3062CF0", Offset = "0x30620F0", Length = "0xBD")]
	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001329")]
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	[Address(RVA = "0x3062C70", Offset = "0x3062070", Length = "0x78")]
	[Token(Token = "0x6001384")]
	private static Array GetComponentsInternal_Injected(IntPtr _unity_self, Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	[Address(RVA = "0x3063000", Offset = "0x3062400", Length = "0x44")]
	[Obsolete("Obsolete. Please use GameObject.GetScene(EntityId entityId) instead.")]
	[Token(Token = "0x6001377")]
	public static Scene GetScene(int instanceID) { }

	[Address(RVA = "0x3063000", Offset = "0x3062400", Length = "0x44")]
	[Token(Token = "0x6001379")]
	public static Scene GetScene(EntityId entityId) { }

	[Address(RVA = "0x3062FB0", Offset = "0x30623B0", Length = "0x44")]
	[FreeFunction(Name = "GameObjectBindings::GetSceneByEntityId")]
	[Token(Token = "0x6001378")]
	private static Scene GetSceneInternal(EntityId entityId) { }

	[Address(RVA = "0x3062F60", Offset = "0x3062360", Length = "0x42")]
	[Token(Token = "0x60013A6")]
	private static void GetSceneInternal_Injected(in EntityId entityId, out Scene ret) { }

	[Address(RVA = "0x3063320", Offset = "0x3062720", Length = "0x22E")]
	[Token(Token = "0x6001376")]
	public static void InstantiateGameObjects(EntityId sourceEntityId, int count, NativeArray<EntityId> newEntityIds, NativeArray<EntityId> newTransformEntityIds, Scene destinationScene = null) { }

	[Address(RVA = "0x30630C0", Offset = "0x30624C0", Length = "0x1EE")]
	[Obsolete("Obsolete. Please use GameObject.InstantiateGameObjects(EntityId, int, NativeArray<EntityId>, NativeArray<EntityId>, Scene) instead.")]
	[Token(Token = "0x6001375")]
	public static void InstantiateGameObjects(int sourceInstanceID, int count, NativeArray<Int32> newInstanceIDs, NativeArray<Int32> newTransformInstanceIDs, Scene destinationScene = null) { }

	[Address(RVA = "0x30632B0", Offset = "0x30626B0", Length = "0x65")]
	[FreeFunction("GameObjectBindings::InstantiateGameObjectsByInstanceID")]
	[Token(Token = "0x6001374")]
	private static void InstantiateGameObjects(EntityId sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, Scene destinationScene) { }

	[Address(RVA = "0x3063050", Offset = "0x3062450", Length = "0x62")]
	[Token(Token = "0x60013A5")]
	private static void InstantiateGameObjects_Injected(in EntityId sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, in Scene destinationScene) { }

	[Address(RVA = "0x3060B00", Offset = "0x305FF00", Length = "0x9F")]
	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	[Token(Token = "0x6001344")]
	private Component Internal_AddComponentWithType(Type componentType) { }

	[Address(RVA = "0x3063550", Offset = "0x3062950", Length = "0x42")]
	[Token(Token = "0x6001389")]
	private static IntPtr Internal_AddComponentWithType_Injected(IntPtr _unity_self, Type componentType) { }

	[Address(RVA = "0x30635F0", Offset = "0x30629F0", Length = "0x187")]
	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	[Token(Token = "0x600136D")]
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[Address(RVA = "0x30635A0", Offset = "0x30629A0", Length = "0x42")]
	[Token(Token = "0x60013A3")]
	private static void Internal_CreateGameObject_Injected(GameObject self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x30637C0", Offset = "0x3062BC0", Length = "0x9D")]
	[NativeName("QueryComponentAtIndex<Unity::Component>")]
	[Token(Token = "0x6001348")]
	internal Component QueryComponentAtIndex(int index) { }

	[Address(RVA = "0x3063780", Offset = "0x3062B80", Length = "0x40")]
	[Token(Token = "0x600138B")]
	private static IntPtr QueryComponentAtIndex_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x3063B80", Offset = "0x3062F80", Length = "0x1DB")]
	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	[Token(Token = "0x6001364")]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[Address(RVA = "0x3063D60", Offset = "0x3063160", Length = "0x1D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001366")]
	public void SendMessage(string methodName) { }

	[Address(RVA = "0x3063D80", Offset = "0x3063180", Length = "0x1A")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001365")]
	public void SendMessage(string methodName, object value) { }

	[Address(RVA = "0x3063DA0", Offset = "0x30631A0", Length = "0x1D")]
	[Token(Token = "0x6001341")]
	public void SendMessage(string methodName, SendMessageOptions options) { }

	[Address(RVA = "0x3063B10", Offset = "0x3062F10", Length = "0x62")]
	[Token(Token = "0x60013A1")]
	private static void SendMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	[Address(RVA = "0x3063AF0", Offset = "0x3062EF0", Length = "0x1D")]
	[Token(Token = "0x6001340")]
	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	[Address(RVA = "0x30638D0", Offset = "0x3062CD0", Length = "0x1DB")]
	[FreeFunction(Name = "Scripting::SendScriptingMessageUpwards", HasExplicitThis = True)]
	[Token(Token = "0x6001361")]
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	[Address(RVA = "0x3063AB0", Offset = "0x3062EB0", Length = "0x1D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001363")]
	public void SendMessageUpwards(string methodName) { }

	[Address(RVA = "0x3063AD0", Offset = "0x3062ED0", Length = "0x1A")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001362")]
	public void SendMessageUpwards(string methodName, object value) { }

	[Address(RVA = "0x3063860", Offset = "0x3062C60", Length = "0x62")]
	[Token(Token = "0x60013A0")]
	private static void SendMessageUpwards_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	[Address(RVA = "0x30652C0", Offset = "0x30646C0", Length = "0x86")]
	[NativeMethod(Name = "SetSelfActive")]
	[Token(Token = "0x6001351")]
	public void set_active(bool value) { }

	[Address(RVA = "0x3065270", Offset = "0x3064670", Length = "0x42")]
	[Token(Token = "0x6001392")]
	private static void set_active_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x30653A0", Offset = "0x30647A0", Length = "0x86")]
	[NativeMethod(Name = "SetIsStaticDeprecated")]
	[Token(Token = "0x6001357")]
	public void set_isStatic(bool value) { }

	[Address(RVA = "0x3065350", Offset = "0x3064750", Length = "0x42")]
	[Token(Token = "0x6001398")]
	private static void set_isStatic_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3065470", Offset = "0x3064870", Length = "0x83")]
	[Token(Token = "0x600134F")]
	public void set_layer(int value) { }

	[Address(RVA = "0x3065430", Offset = "0x3064830", Length = "0x40")]
	[Token(Token = "0x6001390")]
	private static void set_layer_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3065550", Offset = "0x3064950", Length = "0x1C7")]
	[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
	[Token(Token = "0x600135A")]
	public void set_tag(string value) { }

	[Address(RVA = "0x3065500", Offset = "0x3064900", Length = "0x42")]
	[Token(Token = "0x600139B")]
	private static void set_tag_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x3063EF0", Offset = "0x30632F0", Length = "0x86")]
	[NativeMethod(Name = "SetSelfActive")]
	[Token(Token = "0x6001352")]
	public void SetActive(bool value) { }

	[Address(RVA = "0x3063EA0", Offset = "0x30632A0", Length = "0x42")]
	[Token(Token = "0x6001393")]
	private static void SetActive_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3063E10", Offset = "0x3063210", Length = "0x86")]
	[NativeMethod(Name = "SetActiveRecursivelyDeprecated")]
	[Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
	[Token(Token = "0x6001355")]
	public void SetActiveRecursively(bool state) { }

	[Address(RVA = "0x3063DC0", Offset = "0x30631C0", Length = "0x42")]
	[Token(Token = "0x6001396")]
	private static void SetActiveRecursively_Injected(IntPtr _unity_self, bool state) { }

	[Address(RVA = "0x30640D0", Offset = "0x30634D0", Length = "0x52")]
	[FreeFunction(Name = "GameObjectBindings::SetGameObjectsActiveByInstanceID")]
	[Token(Token = "0x600136F")]
	private static void SetGameObjectsActive(IntPtr instanceIds, int instanceCount, bool active) { }

	[Address(RVA = "0x30642B0", Offset = "0x30636B0", Length = "0x104")]
	[Obsolete("Obsolete. Please use GameObject.SetGameObjectsActive(NativeArray<EntityId>, bool) instead.")]
	[Token(Token = "0x6001370")]
	public static void SetGameObjectsActive(NativeArray<Int32> instanceIDs, bool active) { }

	[Address(RVA = "0x3063F80", Offset = "0x3063380", Length = "0x142")]
	[Token(Token = "0x6001371")]
	public static void SetGameObjectsActive(NativeArray<EntityId> entityIds, bool active) { }

	[Address(RVA = "0x3064130", Offset = "0x3063530", Length = "0x9C")]
	[Obsolete("Obsolete. Please use GameObject.SetGameObjectsActive(ReadOnlySpan<EntityId>, bool) instead.")]
	[Token(Token = "0x6001372")]
	public static void SetGameObjectsActive(ReadOnlySpan<Int32> instanceIDs, bool active) { }

	[Address(RVA = "0x30641D0", Offset = "0x30635D0", Length = "0xDA")]
	[Token(Token = "0x6001373")]
	public static void SetGameObjectsActive(ReadOnlySpan<EntityId> entityIds, bool active) { }

	[Address(RVA = "0x30645B0", Offset = "0x30639B0", Length = "0x16F")]
	[Token(Token = "0x600133A")]
	public bool TryGetComponent(Type type, out Component component) { }

	[Address(RVA = "0x8139F0", Offset = "0x812DF0", Length = "0x92")]
	[Token(Token = "0x6001339")]
	public bool TryGetComponent(out T component) { }

	[Address(RVA = "0x3064420", Offset = "0x3063820", Length = "0x95")]
	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600133C")]
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[Address(RVA = "0x30643C0", Offset = "0x30637C0", Length = "0x52")]
	[Token(Token = "0x6001386")]
	private static void TryGetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	[Address(RVA = "0x3064510", Offset = "0x3063910", Length = "0x9F")]
	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600133B")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	internal Component TryGetComponentInternal(Type type) { }

	[Address(RVA = "0x30644C0", Offset = "0x30638C0", Length = "0x42")]
	[Token(Token = "0x6001385")]
	private static IntPtr TryGetComponentInternal_Injected(IntPtr _unity_self, Type type) { }

}

