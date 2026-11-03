namespace UnityEngine;

[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x20001D0")]
public class object
{
	[Token(Token = "0x20001D1")]
	[VisibleToOtherModules]
	public static class MarshalledUnityObject
	{

		[Address(RVA = "0x9F2360", Offset = "0x9F1760", Length = "0x2F")]
		[Token(Token = "0x60014AD")]
		public static IntPtr Marshal(T obj) { }

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x60014AE")]
		public static IntPtr MarshalNotNull(T obj) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60014AF")]
		public static void TryThrowEditorNullExceptionObject(object unityObj, string paramterName) { }

	}

	[Token(Token = "0x40006AD")]
	private const int kInstanceID_None = 0; //Field offset: 0x0
	[Token(Token = "0x40006AF")]
	internal static readonly int OffsetOfInstanceIDInCPlusPlusObject; //Field offset: 0x0
	[Token(Token = "0x40006B0")]
	private const string objectIsNullMessage = "The Object you want to instantiate is null."; //Field offset: 0x0
	[Token(Token = "0x40006B1")]
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AE")]
	private IntPtr m_CachedPtr; //Field offset: 0x10

	[Token(Token = "0x170002FA")]
	public HideFlags hideFlags
	{
		[Address(RVA = "0x306D1C0", Offset = "0x306C5C0", Length = "0x97")]
		[Token(Token = "0x6001467")]
		 get { } //Length: 151
		[Address(RVA = "0x306D540", Offset = "0x306C940", Length = "0xA4")]
		[Token(Token = "0x6001468")]
		 set { } //Length: 164
	}

	[Token(Token = "0x170002F9")]
	public string name
	{
		[Address(RVA = "0x306D260", Offset = "0x306C660", Length = "0x9")]
		[Token(Token = "0x600143E")]
		 get { } //Length: 9
		[Address(RVA = "0x306D5F0", Offset = "0x306C9F0", Length = "0x8")]
		[Token(Token = "0x600143F")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x306D120", Offset = "0x306C520", Length = "0x56")]
	[Token(Token = "0x6001496")]
	private static Object() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001495")]
	public Object() { }

	[Address(RVA = "0x3069B00", Offset = "0x3068F00", Length = "0x54")]
	[Token(Token = "0x6001478")]
	private static void CheckNullArgument(object arg, string message) { }

	[Address(RVA = "0x3069B60", Offset = "0x3068F60", Length = "0xC0")]
	[Token(Token = "0x600143A")]
	private static bool CompareBaseObjects(object lhs, object rhs) { }

	[Address(RVA = "0x3069C30", Offset = "0x3069030", Length = "0x2A")]
	[NativeMethod(Name = "CurrentThreadIsMainThread", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6001483")]
	private static bool CurrentThreadIsMainThread() { }

	[Address(RVA = "0x306A090", Offset = "0x3069490", Length = "0xC0")]
	[ExcludeFromDocs]
	[Token(Token = "0x600145F")]
	public static void Destroy(object obj) { }

	[Address(RVA = "0x3069FF0", Offset = "0x30693F0", Length = "0x9C")]
	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600145E")]
	public static void Destroy(object obj, float t) { }

	[Address(RVA = "0x3069FA0", Offset = "0x30693A0", Length = "0x43")]
	[Token(Token = "0x6001497")]
	private static void Destroy_Injected(IntPtr obj, float t) { }

	[Address(RVA = "0x3069CB0", Offset = "0x30690B0", Length = "0xBF")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001461")]
	public static void DestroyImmediate(object obj) { }

	[Address(RVA = "0x3069D70", Offset = "0x3069170", Length = "0x9C")]
	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6001460")]
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	[Address(RVA = "0x3069C60", Offset = "0x3069060", Length = "0x42")]
	[Token(Token = "0x6001498")]
	private static void DestroyImmediate_Injected(IntPtr obj, bool allowDestroyingAssets) { }

	[Address(RVA = "0x3069E10", Offset = "0x3069210", Length = "0xCD")]
	[Obsolete("use Object.Destroy instead.")]
	[Token(Token = "0x6001469")]
	public static void DestroyObject(object obj, float t) { }

	[Address(RVA = "0x3069EE0", Offset = "0x30692E0", Length = "0xC0")]
	[ExcludeFromDocs]
	[Obsolete("use Object.Destroy instead.")]
	[Token(Token = "0x600146A")]
	public static void DestroyObject(object obj) { }

	[Address(RVA = "0x306A190", Offset = "0x3069590", Length = "0x64")]
	[NativeMethod(Name = "UnityEngineObjectBindings::DoesObjectWithInstanceIDExist", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6001490")]
	internal static bool DoesObjectWithInstanceIDExist(EntityId instanceID) { }

	[Address(RVA = "0x306A150", Offset = "0x3069550", Length = "0x33")]
	[Token(Token = "0x60014A8")]
	private static bool DoesObjectWithInstanceIDExist_Injected(in EntityId instanceID) { }

	[Address(RVA = "0x306A240", Offset = "0x3069640", Length = "0xBC")]
	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	[Token(Token = "0x6001466")]
	public static void DontDestroyOnLoad(object target) { }

	[Address(RVA = "0x306A200", Offset = "0x3069600", Length = "0x33")]
	[Token(Token = "0x6001499")]
	private static void DontDestroyOnLoad_Injected(IntPtr target) { }

	[Address(RVA = "0x306A300", Offset = "0x3069700", Length = "0xB1")]
	[Token(Token = "0x600143B")]
	private void EnsureRunningOnMainThread() { }

	[Address(RVA = "0x306A3C0", Offset = "0x30697C0", Length = "0x224")]
	[Token(Token = "0x6001438")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x306A690", Offset = "0x3069A90", Length = "0xA2")]
	[Token(Token = "0x600147E")]
	public static object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	[Address(RVA = "0x89ADC0", Offset = "0x89A1C0", Length = "0xD0")]
	[Token(Token = "0x6001474")]
	public static T FindAnyObjectByType() { }

	[Address(RVA = "0x306A5F0", Offset = "0x30699F0", Length = "0x92")]
	[Token(Token = "0x600147B")]
	public static object FindAnyObjectByType(Type type) { }

	[Address(RVA = "0x89ACE0", Offset = "0x89A0E0", Length = "0xD2")]
	[Token(Token = "0x6001476")]
	public static T FindAnyObjectByType(FindObjectsInactive findObjectsInactive) { }

	[Address(RVA = "0x89AF80", Offset = "0x89A380", Length = "0xD2")]
	[Token(Token = "0x6001475")]
	public static T FindFirstObjectByType(FindObjectsInactive findObjectsInactive) { }

	[Address(RVA = "0x89AEA0", Offset = "0x89A2A0", Length = "0xD0")]
	[Token(Token = "0x6001473")]
	public static T FindFirstObjectByType() { }

	[Address(RVA = "0x306A740", Offset = "0x3069B40", Length = "0x95")]
	[Token(Token = "0x600147A")]
	public static object FindFirstObjectByType(Type type) { }

	[Address(RVA = "0x306A7E0", Offset = "0x3069BE0", Length = "0xA5")]
	[Token(Token = "0x600147D")]
	public static object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	[Address(RVA = "0x306A8D0", Offset = "0x3069CD0", Length = "0x7F")]
	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[Token(Token = "0x6001491")]
	[VisibleToOtherModules]
	internal static object FindObjectFromInstanceID(EntityId instanceID) { }

	[Address(RVA = "0x306A890", Offset = "0x3069C90", Length = "0x33")]
	[Token(Token = "0x60014A9")]
	private static IntPtr FindObjectFromInstanceID_Injected(in EntityId instanceID) { }

	[Address(RVA = "0x306A9F0", Offset = "0x3069DF0", Length = "0x82")]
	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	[Token(Token = "0x6001479")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object FindObjectOfType(Type type) { }

	[Address(RVA = "0x306A950", Offset = "0x3069D50", Length = "0x94")]
	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	[Token(Token = "0x600147C")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object FindObjectOfType(Type type, bool includeInactive) { }

	[Address(RVA = "0x89B140", Offset = "0x89A540", Length = "0xD5")]
	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	[Token(Token = "0x6001472")]
	public static T FindObjectOfType(bool includeInactive) { }

	[Address(RVA = "0x89B060", Offset = "0x89A460", Length = "0xD0")]
	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	[Token(Token = "0x6001471")]
	public static T FindObjectOfType() { }

	[Address(RVA = "0x89B220", Offset = "0x89A620", Length = "0xA3")]
	[Token(Token = "0x600146E")]
	public static T[] FindObjectsByType(FindObjectsSortMode sortMode) { }

	[Address(RVA = "0x306AAD0", Offset = "0x3069ED0", Length = "0x74")]
	[Token(Token = "0x6001464")]
	public static Object[] FindObjectsByType(Type type, FindObjectsSortMode sortMode) { }

	[Address(RVA = "0x89B2D0", Offset = "0x89A6D0", Length = "0xAF")]
	[Token(Token = "0x6001470")]
	public static T[] FindObjectsByType(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	[Address(RVA = "0x306AA80", Offset = "0x3069E80", Length = "0x50")]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
	[Token(Token = "0x6001465")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	[Address(RVA = "0x306AC70", Offset = "0x306A070", Length = "0x42")]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	[Token(Token = "0x6001463")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	[Address(RVA = "0x306AC00", Offset = "0x306A000", Length = "0x66")]
	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID, but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	[Token(Token = "0x6001462")]
	public static Object[] FindObjectsOfType(Type type) { }

	[Address(RVA = "0x89B380", Offset = "0x89A780", Length = "0xA3")]
	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	[Token(Token = "0x600146F")]
	public static T[] FindObjectsOfType(bool includeInactive) { }

	[Address(RVA = "0x89B430", Offset = "0x89A830", Length = "0x94")]
	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	[Token(Token = "0x600146D")]
	public static T[] FindObjectsOfType() { }

	[Address(RVA = "0x306AB50", Offset = "0x3069F50", Length = "0x6A")]
	[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
	[Token(Token = "0x6001477")]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[Address(RVA = "0x306ABC0", Offset = "0x3069FC0", Length = "0x33")]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
	[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
	[Token(Token = "0x600146C")]
	public static Object[] FindObjectsOfTypeIncludingAssets(Type type) { }

	[Address(RVA = "0x306ACC0", Offset = "0x306A0C0", Length = "0x97")]
	[Obsolete("Object.FindSceneObjectsOfType has been deprecated, Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindSceneObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	[Token(Token = "0x600146B")]
	public static Object[] FindSceneObjectsOfType(Type type) { }

	[Address(RVA = "0x306ADA0", Offset = "0x306A1A0", Length = "0x7F")]
	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	[Token(Token = "0x6001493")]
	[VisibleToOtherModules]
	internal static object ForceLoadFromInstanceID(EntityId instanceID) { }

	[Address(RVA = "0x306AD60", Offset = "0x306A160", Length = "0x33")]
	[Token(Token = "0x60014AB")]
	private static IntPtr ForceLoadFromInstanceID_Injected(in EntityId instanceID) { }

	[Address(RVA = "0x306D1C0", Offset = "0x306C5C0", Length = "0x97")]
	[Token(Token = "0x6001467")]
	public HideFlags get_hideFlags() { }

	[Address(RVA = "0x306D180", Offset = "0x306C580", Length = "0x33")]
	[Token(Token = "0x600149A")]
	private static HideFlags get_hideFlags_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x306D260", Offset = "0x306C660", Length = "0x9")]
	[Token(Token = "0x600143E")]
	public string get_name() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x600143D")]
	private IntPtr GetCachedPtr() { }

	[Address(RVA = "0x306AE20", Offset = "0x306A220", Length = "0x71")]
	[Token(Token = "0x6001435")]
	public EntityId GetEntityId() { }

	[Address(RVA = "0x306AEA0", Offset = "0x306A2A0", Length = "0x9")]
	[Token(Token = "0x6001437")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x306AEB0", Offset = "0x306A2B0", Length = "0x71")]
	[Token(Token = "0x6001436")]
	public int GetInstanceID() { }

	[Address(RVA = "0x306AF80", Offset = "0x306A380", Length = "0x127")]
	[FreeFunction("UnityEngineObjectBindings::GetName", HasExplicitThis = True)]
	[Token(Token = "0x600148D")]
	private string GetName() { }

	[Address(RVA = "0x306AF30", Offset = "0x306A330", Length = "0x42")]
	[Token(Token = "0x60014A5")]
	private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x306B0B0", Offset = "0x306A4B0", Length = "0x2A")]
	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6001482")]
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[Address(RVA = "0x306B140", Offset = "0x306A540", Length = "0x7C")]
	[FreeFunction("UnityEngineObjectBindings::GetPtrFromInstanceID")]
	[Token(Token = "0x6001492")]
	private static IntPtr GetPtrFromInstanceID(EntityId instanceID, Type objectType, out bool isMonoBehaviour) { }

	[Address(RVA = "0x306B0E0", Offset = "0x306A4E0", Length = "0x52")]
	[Token(Token = "0x60014AA")]
	private static IntPtr GetPtrFromInstanceID_Injected(in EntityId instanceID, Type objectType, out bool isMonoBehaviour) { }

	[Address(RVA = "0x89CD80", Offset = "0x89C180", Length = "0xBF")]
	[Token(Token = "0x600145D")]
	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	[Address(RVA = "0x306B220", Offset = "0x306A620", Length = "0x35C")]
	[Token(Token = "0x6001452")]
	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[Address(RVA = "0x306B580", Offset = "0x306A980", Length = "0x201")]
	[Token(Token = "0x6001453")]
	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original) { }

	[Address(RVA = "0x306B790", Offset = "0x306AB90", Length = "0x2E0")]
	[Token(Token = "0x6001451")]
	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x89C7A0", Offset = "0x89BBA0", Length = "0x135")]
	[Token(Token = "0x6001455")]
	public static T Instantiate(T original, InstantiateParameters parameters) { }

	[Address(RVA = "0x89C9E0", Offset = "0x89BDE0", Length = "0x171")]
	[Token(Token = "0x6001456")]
	public static T Instantiate(T original, Vector3 position, Quaternion rotation, InstantiateParameters parameters) { }

	[Address(RVA = "0x306B1C0", Offset = "0x306A5C0", Length = "0x5C")]
	[Token(Token = "0x6001457")]
	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Transform parent) { }

	[Address(RVA = "0x306BA80", Offset = "0x306AE80", Length = "0x305")]
	[Token(Token = "0x6001458")]
	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	[Address(RVA = "0x89CC50", Offset = "0x89C050", Length = "0x124")]
	[Token(Token = "0x6001459")]
	public static T Instantiate(T original) { }

	[Address(RVA = "0x89C6C0", Offset = "0x89BAC0", Length = "0xDA")]
	[Token(Token = "0x600145A")]
	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x89C8E0", Offset = "0x89BCE0", Length = "0xFA")]
	[Token(Token = "0x600145B")]
	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	[Address(RVA = "0x89CB60", Offset = "0x89BF60", Length = "0xEF")]
	[Token(Token = "0x600145C")]
	public static T Instantiate(T original, Transform parent) { }

	[Address(RVA = "0x306BD90", Offset = "0x306B190", Length = "0x216")]
	[Token(Token = "0x6001454")]
	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Scene scene) { }

	[Address(RVA = "0x89BA30", Offset = "0x89AE30", Length = "0x101")]
	[Token(Token = "0x6001443")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Transform parent, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x89B6D0", Offset = "0x89AAD0", Length = "0xCD")]
	[Token(Token = "0x6001442")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x89BB40", Offset = "0x89AF40", Length = "0x136")]
	[Token(Token = "0x6001441")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Transform parent) { }

	[Address(RVA = "0x89C520", Offset = "0x89B920", Length = "0xF2")]
	[Token(Token = "0x6001440")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original) { }

	[Address(RVA = "0x89BF50", Offset = "0x89B350", Length = "0x18F")]
	[Token(Token = "0x6001446")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x89BD90", Offset = "0x89B190", Length = "0x1BC")]
	[Token(Token = "0x6001449")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, Vector3 position, Quaternion rotation, CancellationToken cancellationToken) { }

	[Address(RVA = "0x89C620", Offset = "0x89BA20", Length = "0x95")]
	[Token(Token = "0x6001444")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count) { }

	[Address(RVA = "0x89C1B0", Offset = "0x89B5B0", Length = "0x1B9")]
	[Token(Token = "0x6001448")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x89C0E0", Offset = "0x89B4E0", Length = "0xC1")]
	[Token(Token = "0x6001445")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent) { }

	[Address(RVA = "0x89BC80", Offset = "0x89B080", Length = "0x103")]
	[Token(Token = "0x600144A")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) { }

	[Address(RVA = "0x89B7A0", Offset = "0x89ABA0", Length = "0x107")]
	[Token(Token = "0x600144B")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations, CancellationToken cancellationToken) { }

	[Address(RVA = "0x89C370", Offset = "0x89B770", Length = "0x96")]
	[Token(Token = "0x600144C")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x89C410", Offset = "0x89B810", Length = "0x107")]
	[Token(Token = "0x600144D")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x89B8B0", Offset = "0x89ACB0", Length = "0x17C")]
	[Token(Token = "0x600144E")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Vector3 position, Quaternion rotation, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x89B5B0", Offset = "0x89A9B0", Length = "0x111")]
	[Token(Token = "0x600144F")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Vector3 position, Quaternion rotation, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x88F150", Offset = "0x88E550", Length = "0x200")]
	[Token(Token = "0x6001450")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x89B4D0", Offset = "0x89A8D0", Length = "0xDB")]
	[Token(Token = "0x6001447")]
	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) { }

	[Address(RVA = "0x306C410", Offset = "0x306B810", Length = "0xD6")]
	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6001484")]
	private static object Internal_CloneSingle(object data) { }

	[Address(RVA = "0x306C3D0", Offset = "0x306B7D0", Length = "0x33")]
	[Token(Token = "0x600149C")]
	private static IntPtr Internal_CloneSingle_Injected(IntPtr data) { }

	[Address(RVA = "0x306C000", Offset = "0x306B400", Length = "0xE6")]
	[FreeFunction("CloneObjectWithParams")]
	[Token(Token = "0x6001486")]
	private static object Internal_CloneSingleWithParams(object data, InstantiateParameters parameters) { }

	[Address(RVA = "0x306BFB0", Offset = "0x306B3B0", Length = "0x42")]
	[Token(Token = "0x600149E")]
	private static IntPtr Internal_CloneSingleWithParams_Injected(IntPtr data, in InstantiateParameters parameters) { }

	[Address(RVA = "0x306C150", Offset = "0x306B550", Length = "0x14E")]
	[FreeFunction("CloneObject")]
	[Token(Token = "0x6001488")]
	private static object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	[Address(RVA = "0x306C0F0", Offset = "0x306B4F0", Length = "0x54")]
	[Token(Token = "0x60014A0")]
	private static IntPtr Internal_CloneSingleWithParent_Injected(IntPtr data, IntPtr parent, bool worldPositionStays) { }

	[Address(RVA = "0x306C2F0", Offset = "0x306B6F0", Length = "0xDF")]
	[FreeFunction("CloneObjectToScene")]
	[Token(Token = "0x6001485")]
	private static object Internal_CloneSingleWithScene(object data, Scene scene) { }

	[Address(RVA = "0x306C2A0", Offset = "0x306B6A0", Length = "0x42")]
	[Token(Token = "0x600149D")]
	private static IntPtr Internal_CloneSingleWithScene_Injected(IntPtr data, in Scene scene) { }

	[Address(RVA = "0x306C550", Offset = "0x306B950", Length = "0x10E")]
	[FreeFunction("InstantiateAsyncObjects")]
	[Token(Token = "0x6001489")]
	private static IntPtr Internal_InstantiateAsyncWithParams(object original, int count, InstantiateParameters parameters, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount) { }

	[Address(RVA = "0x306C4F0", Offset = "0x306B8F0", Length = "0x60")]
	[Token(Token = "0x60014A1")]
	private static IntPtr Internal_InstantiateAsyncWithParams_Injected(IntPtr original, int count, in InstantiateParameters parameters, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount) { }

	[Address(RVA = "0x306CA20", Offset = "0x306BE20", Length = "0xFA")]
	[FreeFunction("InstantiateObject")]
	[Token(Token = "0x600148A")]
	private static object Internal_InstantiateSingle(object data, Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x306C9C0", Offset = "0x306BDC0", Length = "0x52")]
	[Token(Token = "0x60014A2")]
	private static IntPtr Internal_InstantiateSingle_Injected(IntPtr data, in Vector3 pos, in Quaternion rot) { }

	[Address(RVA = "0x306C6D0", Offset = "0x306BAD0", Length = "0x10C")]
	[FreeFunction("InstantiateObjectWithParams")]
	[Token(Token = "0x6001487")]
	private static object Internal_InstantiateSingleWithParams(object data, Vector3 position, Quaternion rotation, InstantiateParameters parameters) { }

	[Address(RVA = "0x306C660", Offset = "0x306BA60", Length = "0x62")]
	[Token(Token = "0x600149F")]
	private static IntPtr Internal_InstantiateSingleWithParams_Injected(IntPtr data, in Vector3 position, in Quaternion rotation, in InstantiateParameters parameters) { }

	[Address(RVA = "0x306C850", Offset = "0x306BC50", Length = "0x163")]
	[FreeFunction("InstantiateObject")]
	[Token(Token = "0x600148B")]
	private static object Internal_InstantiateSingleWithParent(object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x306C7E0", Offset = "0x306BBE0", Length = "0x62")]
	[Token(Token = "0x60014A3")]
	private static IntPtr Internal_InstantiateSingleWithParent_Injected(IntPtr data, IntPtr parent, in Vector3 pos, in Quaternion rot) { }

	[Address(RVA = "0x306CB20", Offset = "0x306BF20", Length = "0x1B")]
	[Token(Token = "0x600143C")]
	private static bool IsNativeObjectAlive(object o) { }

	[Address(RVA = "0x306CB80", Offset = "0x306BF80", Length = "0xBC")]
	[FreeFunction("UnityEngineObjectBindings::IsPersistent")]
	[Token(Token = "0x600148E")]
	internal static bool IsPersistent(object obj) { }

	[Address(RVA = "0x306CB40", Offset = "0x306BF40", Length = "0x33")]
	[Token(Token = "0x60014A6")]
	private static bool IsPersistent_Injected(IntPtr obj) { }

	[Address(RVA = "0x306CC80", Offset = "0x306C080", Length = "0x97")]
	[FreeFunction("UnityEngineObjectBindings::MarkObjectDirty", HasExplicitThis = True)]
	[Token(Token = "0x6001494")]
	internal void MarkDirty() { }

	[Address(RVA = "0x306CC40", Offset = "0x306C040", Length = "0x33")]
	[Token(Token = "0x60014AC")]
	private static void MarkDirty_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x306D270", Offset = "0x306C670", Length = "0xFB")]
	[Token(Token = "0x6001480")]
	public static bool op_Equality(object x, object y) { }

	[Address(RVA = "0x306D370", Offset = "0x306C770", Length = "0x87")]
	[Token(Token = "0x6001439")]
	public static bool op_Implicit(object exists) { }

	[Address(RVA = "0x306D400", Offset = "0x306C800", Length = "0xFD")]
	[Token(Token = "0x6001481")]
	public static bool op_Inequality(object x, object y) { }

	[Address(RVA = "0x306D540", Offset = "0x306C940", Length = "0xA4")]
	[Token(Token = "0x6001468")]
	public void set_hideFlags(HideFlags value) { }

	[Address(RVA = "0x306D500", Offset = "0x306C900", Length = "0x40")]
	[Token(Token = "0x600149B")]
	private static void set_hideFlags_Injected(IntPtr _unity_self, HideFlags value) { }

	[Address(RVA = "0x306D5F0", Offset = "0x306C9F0", Length = "0x8")]
	[Token(Token = "0x600143F")]
	public void set_name(string value) { }

	[Address(RVA = "0x306CD70", Offset = "0x306C170", Length = "0x1E8")]
	[FreeFunction("UnityEngineObjectBindings::SetName", HasExplicitThis = True)]
	[Token(Token = "0x600148F")]
	private void SetName(string name) { }

	[Address(RVA = "0x306CD20", Offset = "0x306C120", Length = "0x42")]
	[Token(Token = "0x60014A7")]
	private static void SetName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x306D000", Offset = "0x306C400", Length = "0x11A")]
	[FreeFunction("UnityEngineObjectBindings::ToString")]
	[Token(Token = "0x600148C")]
	private static string ToString(object obj) { }

	[Address(RVA = "0x306CFB0", Offset = "0x306C3B0", Length = "0x49")]
	[Token(Token = "0x600147F")]
	public virtual string ToString() { }

	[Address(RVA = "0x306CF60", Offset = "0x306C360", Length = "0x42")]
	[Token(Token = "0x60014A4")]
	private static void ToString_Injected(IntPtr obj, out ManagedSpanWrapper ret) { }

}

