namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[Token(Token = "0x2000019")]
[UsedByNativeCode]
public class Animator : Behaviour
{

	[Token(Token = "0x17000027")]
	internal bool allowConstantClipSamplingOptimization
	{
		[Address(RVA = "0x2FBDA90", Offset = "0x2FBCE90", Length = "0x76")]
		[Token(Token = "0x6000097")]
		internal get { } //Length: 118
		[Address(RVA = "0x2FC0220", Offset = "0x2FBF620", Length = "0x86")]
		[Token(Token = "0x6000098")]
		internal set { } //Length: 134
	}

	[Token(Token = "0x1700001F")]
	public Vector3 angularVelocity
	{
		[Address(RVA = "0x2FBDB60", Offset = "0x2FBCF60", Length = "0x90")]
		[Token(Token = "0x6000089")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000024")]
	public bool animatePhysics
	{
		[Address(RVA = "0x2FBDC40", Offset = "0x2FBD040", Length = "0x76")]
		[Token(Token = "0x6000092")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC0300", Offset = "0x2FBF700", Length = "0x86")]
		[Token(Token = "0x6000093")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000022")]
	public bool applyRootMotion
	{
		[Address(RVA = "0x2FBDD00", Offset = "0x2FBD100", Length = "0x76")]
		[Token(Token = "0x600008E")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC03E0", Offset = "0x2FBF7E0", Length = "0x86")]
		[Token(Token = "0x600008F")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000040")]
	public Avatar avatar
	{
		[Address(RVA = "0x2FBDEA0", Offset = "0x2FBD2A0", Length = "0x90")]
		[Token(Token = "0x600012D")]
		 get { } //Length: 144
		[Address(RVA = "0x2FC04C0", Offset = "0x2FBF8C0", Length = "0xBA")]
		[Token(Token = "0x600012E")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000038")]
	public Transform avatarRoot
	{
		[Address(RVA = "0x2FBDDC0", Offset = "0x2FBD1C0", Length = "0x90")]
		[Token(Token = "0x6000115")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000029")]
	public Vector3 bodyPosition
	{
		[Address(RVA = "0x2FBE030", Offset = "0x2FBD430", Length = "0xB8")]
		[Token(Token = "0x600009A")]
		 get { } //Length: 184
		[Address(RVA = "0x2FC0660", Offset = "0x2FBFA60", Length = "0x95")]
		[Token(Token = "0x600009B")]
		 set { } //Length: 149
	}

	[Token(Token = "0x1700002A")]
	internal Vector3 bodyPositionInternal
	{
		[Address(RVA = "0x2FBDF90", Offset = "0x2FBD390", Length = "0x90")]
		[NativeMethod("GetBodyPosition")]
		[Token(Token = "0x600009C")]
		internal get { } //Length: 144
		[Address(RVA = "0x2FC05D0", Offset = "0x2FBF9D0", Length = "0x85")]
		[NativeMethod("SetBodyPosition")]
		[Token(Token = "0x600009D")]
		internal set { } //Length: 133
	}

	[Token(Token = "0x1700002B")]
	public Quaternion bodyRotation
	{
		[Address(RVA = "0x2FBE1D0", Offset = "0x2FBD5D0", Length = "0xAA")]
		[Token(Token = "0x600009E")]
		 get { } //Length: 170
		[Address(RVA = "0x2FC07E0", Offset = "0x2FBFBE0", Length = "0x8C")]
		[Token(Token = "0x600009F")]
		 set { } //Length: 140
	}

	[Token(Token = "0x1700002C")]
	internal Quaternion bodyRotationInternal
	{
		[Address(RVA = "0x2FBE140", Offset = "0x2FBD540", Length = "0x8E")]
		[NativeMethod("GetBodyRotation")]
		[Token(Token = "0x60000A0")]
		internal get { } //Length: 142
		[Address(RVA = "0x2FC0750", Offset = "0x2FBFB50", Length = "0x85")]
		[NativeMethod("SetBodyRotation")]
		[Token(Token = "0x60000A1")]
		internal set { } //Length: 133
	}

	[Token(Token = "0x17000039")]
	public AnimatorCullingMode cullingMode
	{
		[Address(RVA = "0x2FBE2C0", Offset = "0x2FBD6C0", Length = "0x76")]
		[Token(Token = "0x6000118")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC08B0", Offset = "0x2FBFCB0", Length = "0x83")]
		[Token(Token = "0x6000119")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700001C")]
	public Vector3 deltaPosition
	{
		[Address(RVA = "0x2FBE390", Offset = "0x2FBD790", Length = "0x90")]
		[Token(Token = "0x6000086")]
		 get { } //Length: 144
	}

	[Token(Token = "0x1700001D")]
	public Quaternion deltaRotation
	{
		[Address(RVA = "0x2FBE480", Offset = "0x2FBD880", Length = "0x8E")]
		[Token(Token = "0x6000087")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000031")]
	public float feetPivotActive
	{
		[Address(RVA = "0x2FBE550", Offset = "0x2FBD950", Length = "0x76")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC0990", Offset = "0x2FBFD90", Length = "0x86")]
		[Token(Token = "0x60000E5")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000047")]
	public bool fireEvents
	{
		[Address(RVA = "0x2FBE610", Offset = "0x2FBDA10", Length = "0x76")]
		[Token(Token = "0x600015C")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC0A70", Offset = "0x2FBFE70", Length = "0x86")]
		[Token(Token = "0x600015D")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000028")]
	public float gravityWeight
	{
		[Address(RVA = "0x2FBE6D0", Offset = "0x2FBDAD0", Length = "0x76")]
		[Token(Token = "0x6000099")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700003F")]
	public bool hasBoundPlayables
	{
		[Address(RVA = "0x2FBE790", Offset = "0x2FBDB90", Length = "0x76")]
		[NativeMethod("HasBoundPlayables")]
		[Token(Token = "0x6000129")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000018")]
	public bool hasRootMotion
	{
		[Address(RVA = "0x2FBE850", Offset = "0x2FBDC50", Length = "0x76")]
		[NativeMethod("HasRootMotion")]
		[Token(Token = "0x600006E")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000026")]
	public bool hasTransformHierarchy
	{
		[Address(RVA = "0x2FBE910", Offset = "0x2FBDD10", Length = "0x76")]
		[Token(Token = "0x6000096")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700001A")]
	public float humanScale
	{
		[Address(RVA = "0x2FBE9D0", Offset = "0x2FBDDD0", Length = "0x76")]
		[Token(Token = "0x6000070")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000017")]
	public bool isHuman
	{
		[Address(RVA = "0x2FBEA90", Offset = "0x2FBDE90", Length = "0x76")]
		[NativeMethod("IsHuman")]
		[Token(Token = "0x600006D")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700001B")]
	public bool isInitialized
	{
		[Address(RVA = "0x2FBEB50", Offset = "0x2FBDF50", Length = "0x76")]
		[NativeMethod("IsInitialized")]
		[Token(Token = "0x6000071")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000034")]
	public bool isMatchingTarget
	{
		[Address(RVA = "0x2FBEC10", Offset = "0x2FBE010", Length = "0x76")]
		[NativeMethod("IsMatchingTarget")]
		[Token(Token = "0x60000EE")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000016")]
	public bool isOptimizable
	{
		[Address(RVA = "0x2FBECD0", Offset = "0x2FBE0D0", Length = "0x76")]
		[NativeMethod("IsOptimizable")]
		[Token(Token = "0x600006C")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000019")]
	internal bool isRootPositionOrRotationControlledByCurves
	{
		[Address(RVA = "0x2FBED90", Offset = "0x2FBE190", Length = "0x76")]
		[NativeMethod("IsRootTranslationOrRotationControllerByCurves")]
		[Token(Token = "0x600006F")]
		internal get { } //Length: 118
	}

	[Obsolete("keepAnimatorControllerStateOnDisable is deprecated, use keepAnimatorStateOnDisable instead. (UnityUpgradable) -> keepAnimatorStateOnDisable", False)]
	[Token(Token = "0x17000048")]
	public bool keepAnimatorControllerStateOnDisable
	{
		[Address(RVA = "0x2FBEE10", Offset = "0x2FBE210", Length = "0x76")]
		[Token(Token = "0x600015E")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC0B00", Offset = "0x2FBFF00", Length = "0x86")]
		[Token(Token = "0x600015F")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000049")]
	public bool keepAnimatorStateOnDisable
	{
		[Address(RVA = "0x2FBEE10", Offset = "0x2FBE210", Length = "0x76")]
		[Token(Token = "0x6000160")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC0B00", Offset = "0x2FBFF00", Length = "0x86")]
		[Token(Token = "0x6000161")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700002E")]
	public int layerCount
	{
		[Address(RVA = "0x2FBEF10", Offset = "0x2FBE310", Length = "0x76")]
		[Token(Token = "0x60000CD")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000042")]
	public bool layersAffectMassCenter
	{
		[Address(RVA = "0x2FBEFD0", Offset = "0x2FBE3D0", Length = "0x76")]
		[Token(Token = "0x6000148")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC0C30", Offset = "0x2FC0030", Length = "0x86")]
		[Token(Token = "0x6000149")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000043")]
	public float leftFeetBottomHeight
	{
		[Address(RVA = "0x2FBF090", Offset = "0x2FBE490", Length = "0x76")]
		[Token(Token = "0x600014A")]
		 get { } //Length: 118
	}

	[Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
	[Token(Token = "0x17000023")]
	public bool linearVelocityBlending
	{
		[Address(RVA = "0x2FBF150", Offset = "0x2FBE550", Length = "0x76")]
		[Token(Token = "0x6000090")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC0D10", Offset = "0x2FC0110", Length = "0x86")]
		[Token(Token = "0x6000091")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000046")]
	public bool logWarnings
	{
		[Address(RVA = "0x2FBF210", Offset = "0x2FBE610", Length = "0x76")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC0DF0", Offset = "0x2FC01F0", Length = "0x86")]
		[Token(Token = "0x600015B")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000030")]
	public int parameterCount
	{
		[Address(RVA = "0x2FBF2D0", Offset = "0x2FBE6D0", Length = "0x76")]
		[Token(Token = "0x60000E1")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700002F")]
	public AnimatorControllerParameter[] parameters
	{
		[Address(RVA = "0x2FBF390", Offset = "0x2FBE790", Length = "0x76")]
		[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000033")]
	public Vector3 pivotPosition
	{
		[Address(RVA = "0x2FBF460", Offset = "0x2FBE860", Length = "0x90")]
		[Token(Token = "0x60000E7")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000032")]
	public float pivotWeight
	{
		[Address(RVA = "0x2FBF540", Offset = "0x2FBE940", Length = "0x76")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000041")]
	public PlayableGraph playableGraph
	{
		[Address(RVA = "0x2FBF5C0", Offset = "0x2FBE9C0", Length = "0x9D")]
		[Token(Token = "0x6000130")]
		 get { } //Length: 157
	}

	[Token(Token = "0x1700003A")]
	public float playbackTime
	{
		[Address(RVA = "0x2FBF6A0", Offset = "0x2FBEAA0", Length = "0x76")]
		[Token(Token = "0x600011C")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC0ED0", Offset = "0x2FC02D0", Length = "0x86")]
		[Token(Token = "0x600011D")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700003D")]
	public AnimatorRecorderMode recorderMode
	{
		[Address(RVA = "0x2FBF760", Offset = "0x2FBEB60", Length = "0x76")]
		[Token(Token = "0x6000126")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700003B")]
	public float recorderStartTime
	{
		[Address(RVA = "0x2FB8CE0", Offset = "0x2FB80E0", Length = "0x76")]
		[Token(Token = "0x6000120")]
		 get { } //Length: 118
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000121")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700003C")]
	public float recorderStopTime
	{
		[Address(RVA = "0x2FB8DA0", Offset = "0x2FB81A0", Length = "0x76")]
		[Token(Token = "0x6000123")]
		 get { } //Length: 118
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000124")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000044")]
	public float rightFeetBottomHeight
	{
		[Address(RVA = "0x2FBF820", Offset = "0x2FBEC20", Length = "0x76")]
		[Token(Token = "0x600014B")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000020")]
	public Vector3 rootPosition
	{
		[Address(RVA = "0x2FBF8F0", Offset = "0x2FBECF0", Length = "0x90")]
		[NativeMethod("GetAvatarPosition")]
		[Token(Token = "0x600008A")]
		 get { } //Length: 144
		[Address(RVA = "0x2FC0FB0", Offset = "0x2FC03B0", Length = "0x85")]
		[NativeMethod("SetAvatarPosition")]
		[Token(Token = "0x600008B")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000021")]
	public Quaternion rootRotation
	{
		[Address(RVA = "0x2FBF9E0", Offset = "0x2FBEDE0", Length = "0x8E")]
		[NativeMethod("GetAvatarRotation")]
		[Token(Token = "0x600008C")]
		 get { } //Length: 142
		[Address(RVA = "0x2FC1090", Offset = "0x2FC0490", Length = "0x85")]
		[NativeMethod("SetAvatarRotation")]
		[Token(Token = "0x600008D")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700003E")]
	public RuntimeAnimatorController runtimeAnimatorController
	{
		[Address(RVA = "0x2FBFAB0", Offset = "0x2FBEEB0", Length = "0x90")]
		[Token(Token = "0x6000127")]
		 get { } //Length: 144
		[Address(RVA = "0x2FC1170", Offset = "0x2FC0570", Length = "0xBA")]
		[Token(Token = "0x6000128")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000035")]
	public float speed
	{
		[Address(RVA = "0x2FBFB90", Offset = "0x2FBEF90", Length = "0x76")]
		[Token(Token = "0x60000EF")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC1280", Offset = "0x2FC0680", Length = "0x86")]
		[Token(Token = "0x60000F0")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700002D")]
	public bool stabilizeFeet
	{
		[Address(RVA = "0x2FBFC50", Offset = "0x2FBF050", Length = "0x76")]
		[Token(Token = "0x60000CB")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC1360", Offset = "0x2FC0760", Length = "0x86")]
		[Token(Token = "0x60000CC")]
		 set { } //Length: 134
	}

	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x17000045")]
	internal bool supportsOnAnimatorMove
	{
		[Address(RVA = "0x2FBFD10", Offset = "0x2FBF110", Length = "0x76")]
		[NativeMethod("SupportsOnAnimatorMove")]
		[Token(Token = "0x600014C")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000036")]
	public Vector3 targetPosition
	{
		[Address(RVA = "0x2FBFDE0", Offset = "0x2FBF1E0", Length = "0x90")]
		[Token(Token = "0x6000111")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000037")]
	public Quaternion targetRotation
	{
		[Address(RVA = "0x2FBFED0", Offset = "0x2FBF2D0", Length = "0x8E")]
		[Token(Token = "0x6000112")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000025")]
	public AnimatorUpdateMode updateMode
	{
		[Address(RVA = "0x2FBFFA0", Offset = "0x2FBF3A0", Length = "0x76")]
		[Token(Token = "0x6000094")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC1430", Offset = "0x2FC0830", Length = "0x83")]
		[Token(Token = "0x6000095")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700001E")]
	public Vector3 velocity
	{
		[Address(RVA = "0x2FC0070", Offset = "0x2FBF470", Length = "0x90")]
		[Token(Token = "0x6000088")]
		 get { } //Length: 144
	}

	[Token(Token = "0x1700004A")]
	public bool writeDefaultValuesOnDisable
	{
		[Address(RVA = "0x2FC0150", Offset = "0x2FBF550", Length = "0x76")]
		[Token(Token = "0x6000162")]
		 get { } //Length: 118
		[Address(RVA = "0x2FC1510", Offset = "0x2FC0910", Length = "0x86")]
		[Token(Token = "0x6000163")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600016C")]
	public Animator() { }

	[Address(RVA = "0x2FB4CF0", Offset = "0x2FB40F0", Length = "0x76")]
	[Token(Token = "0x6000153")]
	public void ApplyBuiltinRootMotion() { }

	[Address(RVA = "0x2FB4CB0", Offset = "0x2FB40B0", Length = "0x33")]
	[Token(Token = "0x60001F7")]
	private static void ApplyBuiltinRootMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FB4D70", Offset = "0x2FB4170", Length = "0x120")]
	[Token(Token = "0x6000132")]
	private void CheckIfInIKPass() { }

	[Address(RVA = "0x2FB4EE0", Offset = "0x2FB42E0", Length = "0x76")]
	[Token(Token = "0x600012A")]
	internal void ClearInternalControllerPlayable() { }

	[Address(RVA = "0x2FB4EA0", Offset = "0x2FB42A0", Length = "0x33")]
	[Token(Token = "0x60001D1")]
	private static void ClearInternalControllerPlayable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x768750", Offset = "0x767B50", Length = "0x135")]
	[Token(Token = "0x60000C6")]
	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	[Address(RVA = "0x2FB55F0", Offset = "0x2FB49F0", Length = "0xBA")]
	[Token(Token = "0x6000101")]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	[Address(RVA = "0x2FB5780", Offset = "0x2FB4B80", Length = "0xB9")]
	[Token(Token = "0x60000FB")]
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	[Address(RVA = "0x2FB56B0", Offset = "0x2FB4AB0", Length = "0xC7")]
	[Token(Token = "0x60000FC")]
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	[Address(RVA = "0x2FB58F0", Offset = "0x2FB4CF0", Length = "0xB0")]
	[Token(Token = "0x6000102")]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	[Address(RVA = "0x2FB59B0", Offset = "0x2FB4DB0", Length = "0xBD")]
	[Token(Token = "0x60000FD")]
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	[Address(RVA = "0x2FB5B30", Offset = "0x2FB4F30", Length = "0xAC")]
	[Token(Token = "0x6000100")]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	[Address(RVA = "0x2FB5840", Offset = "0x2FB4C40", Length = "0xA3")]
	[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = True)]
	[Token(Token = "0x60000FF")]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[Address(RVA = "0x2FB5A70", Offset = "0x2FB4E70", Length = "0xB0")]
	[Token(Token = "0x60000FE")]
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[Address(RVA = "0x2FB5590", Offset = "0x2FB4990", Length = "0x60")]
	[Token(Token = "0x60001B9")]
	private static void CrossFade_Injected(IntPtr _unity_self, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[Address(RVA = "0x2FB5360", Offset = "0x2FB4760", Length = "0xAC")]
	[Token(Token = "0x60000F6")]
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	[Address(RVA = "0x2FB5080", Offset = "0x2FB4480", Length = "0xA8")]
	[Token(Token = "0x60000F8")]
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	[Address(RVA = "0x2FB5410", Offset = "0x2FB4810", Length = "0xB0")]
	[Token(Token = "0x60000F5")]
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	[Address(RVA = "0x2FB54D0", Offset = "0x2FB48D0", Length = "0xB5")]
	[Token(Token = "0x60000F2")]
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	[Address(RVA = "0x2FB4FC0", Offset = "0x2FB43C0", Length = "0xB2")]
	[Token(Token = "0x60000F7")]
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	[Address(RVA = "0x2FB51F0", Offset = "0x2FB45F0", Length = "0xA3")]
	[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = True)]
	[Token(Token = "0x60000F9")]
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	[Address(RVA = "0x2FB5130", Offset = "0x2FB4530", Length = "0xBF")]
	[Token(Token = "0x60000F3")]
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	[Address(RVA = "0x2FB52A0", Offset = "0x2FB46A0", Length = "0xB9")]
	[Token(Token = "0x60000F4")]
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	[Address(RVA = "0x2FB4F60", Offset = "0x2FB4360", Length = "0x60")]
	[Token(Token = "0x60001B7")]
	private static void CrossFadeInFixedTime_Injected(IntPtr _unity_self, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	[Address(RVA = "0x2FB5CC0", Offset = "0x2FB50C0", Length = "0x79")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x6000154")]
	internal void EvaluateController() { }

	[Address(RVA = "0x2FB5C30", Offset = "0x2FB5030", Length = "0x86")]
	[Token(Token = "0x6000155")]
	private void EvaluateController(float deltaTime) { }

	[Address(RVA = "0x2FB5BE0", Offset = "0x2FB4FE0", Length = "0x43")]
	[Token(Token = "0x60001F8")]
	private static void EvaluateController_Injected(IntPtr _unity_self, float deltaTime) { }

	[Address(RVA = "0x2FB5D40", Offset = "0x2FB5140", Length = "0x8B")]
	[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
	[Token(Token = "0x60000F1")]
	public void ForceStateNormalizedTime(float normalizedTime) { }

	[Address(RVA = "0x2FBDA90", Offset = "0x2FBCE90", Length = "0x76")]
	[Token(Token = "0x6000097")]
	internal bool get_allowConstantClipSamplingOptimization() { }

	[Address(RVA = "0x2FBDA50", Offset = "0x2FBCE50", Length = "0x33")]
	[Token(Token = "0x6000184")]
	private static bool get_allowConstantClipSamplingOptimization_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBDB60", Offset = "0x2FBCF60", Length = "0x90")]
	[Token(Token = "0x6000089")]
	public Vector3 get_angularVelocity() { }

	[Address(RVA = "0x2FBDB10", Offset = "0x2FBCF10", Length = "0x42")]
	[Token(Token = "0x6000176")]
	private static void get_angularVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FBDC40", Offset = "0x2FBD040", Length = "0x76")]
	[Token(Token = "0x6000092")]
	public bool get_animatePhysics() { }

	[Address(RVA = "0x2FBDC00", Offset = "0x2FBD000", Length = "0x33")]
	[Token(Token = "0x600017F")]
	private static bool get_animatePhysics_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBDD00", Offset = "0x2FBD100", Length = "0x76")]
	[Token(Token = "0x600008E")]
	public bool get_applyRootMotion() { }

	[Address(RVA = "0x2FBDCC0", Offset = "0x2FBD0C0", Length = "0x33")]
	[Token(Token = "0x600017B")]
	private static bool get_applyRootMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBDEA0", Offset = "0x2FBD2A0", Length = "0x90")]
	[Token(Token = "0x600012D")]
	public Avatar get_avatar() { }

	[Address(RVA = "0x2FBDE60", Offset = "0x2FBD260", Length = "0x33")]
	[Token(Token = "0x60001D4")]
	private static IntPtr get_avatar_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBDDC0", Offset = "0x2FBD1C0", Length = "0x90")]
	[Token(Token = "0x6000115")]
	public Transform get_avatarRoot() { }

	[Address(RVA = "0x2FBDD80", Offset = "0x2FBD180", Length = "0x33")]
	[Token(Token = "0x60001C1")]
	private static IntPtr get_avatarRoot_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBE030", Offset = "0x2FBD430", Length = "0xB8")]
	[Token(Token = "0x600009A")]
	public Vector3 get_bodyPosition() { }

	[Address(RVA = "0x2FBDF90", Offset = "0x2FBD390", Length = "0x90")]
	[NativeMethod("GetBodyPosition")]
	[Token(Token = "0x600009C")]
	internal Vector3 get_bodyPositionInternal() { }

	[Address(RVA = "0x2FBDF40", Offset = "0x2FBD340", Length = "0x42")]
	[Token(Token = "0x6000187")]
	private static void get_bodyPositionInternal_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FBE1D0", Offset = "0x2FBD5D0", Length = "0xAA")]
	[Token(Token = "0x600009E")]
	public Quaternion get_bodyRotation() { }

	[Address(RVA = "0x2FBE140", Offset = "0x2FBD540", Length = "0x8E")]
	[NativeMethod("GetBodyRotation")]
	[Token(Token = "0x60000A0")]
	internal Quaternion get_bodyRotationInternal() { }

	[Address(RVA = "0x2FBE0F0", Offset = "0x2FBD4F0", Length = "0x42")]
	[Token(Token = "0x6000189")]
	private static void get_bodyRotationInternal_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x2FBE2C0", Offset = "0x2FBD6C0", Length = "0x76")]
	[Token(Token = "0x6000118")]
	public AnimatorCullingMode get_cullingMode() { }

	[Address(RVA = "0x2FBE280", Offset = "0x2FBD680", Length = "0x33")]
	[Token(Token = "0x60001C3")]
	private static AnimatorCullingMode get_cullingMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBE390", Offset = "0x2FBD790", Length = "0x90")]
	[Token(Token = "0x6000086")]
	public Vector3 get_deltaPosition() { }

	[Address(RVA = "0x2FBE340", Offset = "0x2FBD740", Length = "0x42")]
	[Token(Token = "0x6000173")]
	private static void get_deltaPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FBE480", Offset = "0x2FBD880", Length = "0x8E")]
	[Token(Token = "0x6000087")]
	public Quaternion get_deltaRotation() { }

	[Address(RVA = "0x2FBE430", Offset = "0x2FBD830", Length = "0x42")]
	[Token(Token = "0x6000174")]
	private static void get_deltaRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x2FBE550", Offset = "0x2FBD950", Length = "0x76")]
	[Token(Token = "0x60000E4")]
	public float get_feetPivotActive() { }

	[Address(RVA = "0x2FBE510", Offset = "0x2FBD910", Length = "0x33")]
	[Token(Token = "0x60001AE")]
	private static float get_feetPivotActive_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBE610", Offset = "0x2FBDA10", Length = "0x76")]
	[Token(Token = "0x600015C")]
	public bool get_fireEvents() { }

	[Address(RVA = "0x2FBE5D0", Offset = "0x2FBD9D0", Length = "0x33")]
	[Token(Token = "0x60001FD")]
	private static bool get_fireEvents_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBE6D0", Offset = "0x2FBDAD0", Length = "0x76")]
	[Token(Token = "0x6000099")]
	public float get_gravityWeight() { }

	[Address(RVA = "0x2FBE690", Offset = "0x2FBDA90", Length = "0x33")]
	[Token(Token = "0x6000186")]
	private static float get_gravityWeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBE790", Offset = "0x2FBDB90", Length = "0x76")]
	[NativeMethod("HasBoundPlayables")]
	[Token(Token = "0x6000129")]
	public bool get_hasBoundPlayables() { }

	[Address(RVA = "0x2FBE750", Offset = "0x2FBDB50", Length = "0x33")]
	[Token(Token = "0x60001D0")]
	private static bool get_hasBoundPlayables_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBE850", Offset = "0x2FBDC50", Length = "0x76")]
	[NativeMethod("HasRootMotion")]
	[Token(Token = "0x600006E")]
	public bool get_hasRootMotion() { }

	[Address(RVA = "0x2FBE810", Offset = "0x2FBDC10", Length = "0x33")]
	[Token(Token = "0x600016F")]
	private static bool get_hasRootMotion_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBE910", Offset = "0x2FBDD10", Length = "0x76")]
	[Token(Token = "0x6000096")]
	public bool get_hasTransformHierarchy() { }

	[Address(RVA = "0x2FBE8D0", Offset = "0x2FBDCD0", Length = "0x33")]
	[Token(Token = "0x6000183")]
	private static bool get_hasTransformHierarchy_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBE9D0", Offset = "0x2FBDDD0", Length = "0x76")]
	[Token(Token = "0x6000070")]
	public float get_humanScale() { }

	[Address(RVA = "0x2FBE990", Offset = "0x2FBDD90", Length = "0x33")]
	[Token(Token = "0x6000171")]
	private static float get_humanScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBEA90", Offset = "0x2FBDE90", Length = "0x76")]
	[NativeMethod("IsHuman")]
	[Token(Token = "0x600006D")]
	public bool get_isHuman() { }

	[Address(RVA = "0x2FBEA50", Offset = "0x2FBDE50", Length = "0x33")]
	[Token(Token = "0x600016E")]
	private static bool get_isHuman_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBEB50", Offset = "0x2FBDF50", Length = "0x76")]
	[NativeMethod("IsInitialized")]
	[Token(Token = "0x6000071")]
	public bool get_isInitialized() { }

	[Address(RVA = "0x2FBEB10", Offset = "0x2FBDF10", Length = "0x33")]
	[Token(Token = "0x6000172")]
	private static bool get_isInitialized_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBEC10", Offset = "0x2FBE010", Length = "0x76")]
	[NativeMethod("IsMatchingTarget")]
	[Token(Token = "0x60000EE")]
	public bool get_isMatchingTarget() { }

	[Address(RVA = "0x2FBEBD0", Offset = "0x2FBDFD0", Length = "0x33")]
	[Token(Token = "0x60001B4")]
	private static bool get_isMatchingTarget_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBECD0", Offset = "0x2FBE0D0", Length = "0x76")]
	[NativeMethod("IsOptimizable")]
	[Token(Token = "0x600006C")]
	public bool get_isOptimizable() { }

	[Address(RVA = "0x2FBEC90", Offset = "0x2FBE090", Length = "0x33")]
	[Token(Token = "0x600016D")]
	private static bool get_isOptimizable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBED90", Offset = "0x2FBE190", Length = "0x76")]
	[NativeMethod("IsRootTranslationOrRotationControllerByCurves")]
	[Token(Token = "0x600006F")]
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	[Address(RVA = "0x2FBED50", Offset = "0x2FBE150", Length = "0x33")]
	[Token(Token = "0x6000170")]
	private static bool get_isRootPositionOrRotationControlledByCurves_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBEE10", Offset = "0x2FBE210", Length = "0x76")]
	[Token(Token = "0x600015E")]
	public bool get_keepAnimatorControllerStateOnDisable() { }

	[Address(RVA = "0x2FBEE10", Offset = "0x2FBE210", Length = "0x76")]
	[Token(Token = "0x6000160")]
	public bool get_keepAnimatorStateOnDisable() { }

	[Address(RVA = "0x2FBEE90", Offset = "0x2FBE290", Length = "0x33")]
	[Token(Token = "0x60001FF")]
	private static bool get_keepAnimatorStateOnDisable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBEF10", Offset = "0x2FBE310", Length = "0x76")]
	[Token(Token = "0x60000CD")]
	public int get_layerCount() { }

	[Address(RVA = "0x2FBEED0", Offset = "0x2FBE2D0", Length = "0x33")]
	[Token(Token = "0x600019F")]
	private static int get_layerCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBEFD0", Offset = "0x2FBE3D0", Length = "0x76")]
	[Token(Token = "0x6000148")]
	public bool get_layersAffectMassCenter() { }

	[Address(RVA = "0x2FBEF90", Offset = "0x2FBE390", Length = "0x33")]
	[Token(Token = "0x60001ED")]
	private static bool get_layersAffectMassCenter_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBF090", Offset = "0x2FBE490", Length = "0x76")]
	[Token(Token = "0x600014A")]
	public float get_leftFeetBottomHeight() { }

	[Address(RVA = "0x2FBF050", Offset = "0x2FBE450", Length = "0x33")]
	[Token(Token = "0x60001EF")]
	private static float get_leftFeetBottomHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBF150", Offset = "0x2FBE550", Length = "0x76")]
	[Token(Token = "0x6000090")]
	public bool get_linearVelocityBlending() { }

	[Address(RVA = "0x2FBF110", Offset = "0x2FBE510", Length = "0x33")]
	[Token(Token = "0x600017D")]
	private static bool get_linearVelocityBlending_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBF210", Offset = "0x2FBE610", Length = "0x76")]
	[Token(Token = "0x600015A")]
	public bool get_logWarnings() { }

	[Address(RVA = "0x2FBF1D0", Offset = "0x2FBE5D0", Length = "0x33")]
	[Token(Token = "0x60001FB")]
	private static bool get_logWarnings_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBF2D0", Offset = "0x2FBE6D0", Length = "0x76")]
	[Token(Token = "0x60000E1")]
	public int get_parameterCount() { }

	[Address(RVA = "0x2FBF290", Offset = "0x2FBE690", Length = "0x33")]
	[Token(Token = "0x60001AC")]
	private static int get_parameterCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBF390", Offset = "0x2FBE790", Length = "0x76")]
	[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
	[Token(Token = "0x60000E0")]
	public AnimatorControllerParameter[] get_parameters() { }

	[Address(RVA = "0x2FBF350", Offset = "0x2FBE750", Length = "0x33")]
	[Token(Token = "0x60001AB")]
	private static AnimatorControllerParameter[] get_parameters_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBF460", Offset = "0x2FBE860", Length = "0x90")]
	[Token(Token = "0x60000E7")]
	public Vector3 get_pivotPosition() { }

	[Address(RVA = "0x2FBF410", Offset = "0x2FBE810", Length = "0x42")]
	[Token(Token = "0x60001B1")]
	private static void get_pivotPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FBF540", Offset = "0x2FBE940", Length = "0x76")]
	[Token(Token = "0x60000E6")]
	public float get_pivotWeight() { }

	[Address(RVA = "0x2FBF500", Offset = "0x2FBE900", Length = "0x33")]
	[Token(Token = "0x60001B0")]
	private static float get_pivotWeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBF5C0", Offset = "0x2FBE9C0", Length = "0x9D")]
	[Token(Token = "0x6000130")]
	public PlayableGraph get_playableGraph() { }

	[Address(RVA = "0x2FBF6A0", Offset = "0x2FBEAA0", Length = "0x76")]
	[Token(Token = "0x600011C")]
	public float get_playbackTime() { }

	[Address(RVA = "0x2FBF660", Offset = "0x2FBEA60", Length = "0x33")]
	[Token(Token = "0x60001C7")]
	private static float get_playbackTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBF760", Offset = "0x2FBEB60", Length = "0x76")]
	[Token(Token = "0x6000126")]
	public AnimatorRecorderMode get_recorderMode() { }

	[Address(RVA = "0x2FBF720", Offset = "0x2FBEB20", Length = "0x33")]
	[Token(Token = "0x60001CD")]
	private static AnimatorRecorderMode get_recorderMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FB8CE0", Offset = "0x2FB80E0", Length = "0x76")]
	[Token(Token = "0x6000120")]
	public float get_recorderStartTime() { }

	[Address(RVA = "0x2FB8DA0", Offset = "0x2FB81A0", Length = "0x76")]
	[Token(Token = "0x6000123")]
	public float get_recorderStopTime() { }

	[Address(RVA = "0x2FBF820", Offset = "0x2FBEC20", Length = "0x76")]
	[Token(Token = "0x600014B")]
	public float get_rightFeetBottomHeight() { }

	[Address(RVA = "0x2FBF7E0", Offset = "0x2FBEBE0", Length = "0x33")]
	[Token(Token = "0x60001F0")]
	private static float get_rightFeetBottomHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBF8F0", Offset = "0x2FBECF0", Length = "0x90")]
	[NativeMethod("GetAvatarPosition")]
	[Token(Token = "0x600008A")]
	public Vector3 get_rootPosition() { }

	[Address(RVA = "0x2FBF8A0", Offset = "0x2FBECA0", Length = "0x42")]
	[Token(Token = "0x6000177")]
	private static void get_rootPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FBF9E0", Offset = "0x2FBEDE0", Length = "0x8E")]
	[NativeMethod("GetAvatarRotation")]
	[Token(Token = "0x600008C")]
	public Quaternion get_rootRotation() { }

	[Address(RVA = "0x2FBF990", Offset = "0x2FBED90", Length = "0x42")]
	[Token(Token = "0x6000179")]
	private static void get_rootRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x2FBFAB0", Offset = "0x2FBEEB0", Length = "0x90")]
	[Token(Token = "0x6000127")]
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	[Address(RVA = "0x2FBFA70", Offset = "0x2FBEE70", Length = "0x33")]
	[Token(Token = "0x60001CE")]
	private static IntPtr get_runtimeAnimatorController_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBFB90", Offset = "0x2FBEF90", Length = "0x76")]
	[Token(Token = "0x60000EF")]
	public float get_speed() { }

	[Address(RVA = "0x2FBFB50", Offset = "0x2FBEF50", Length = "0x33")]
	[Token(Token = "0x60001B5")]
	private static float get_speed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBFC50", Offset = "0x2FBF050", Length = "0x76")]
	[Token(Token = "0x60000CB")]
	public bool get_stabilizeFeet() { }

	[Address(RVA = "0x2FBFC10", Offset = "0x2FBF010", Length = "0x33")]
	[Token(Token = "0x600019D")]
	private static bool get_stabilizeFeet_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBFD10", Offset = "0x2FBF110", Length = "0x76")]
	[NativeMethod("SupportsOnAnimatorMove")]
	[Token(Token = "0x600014C")]
	internal bool get_supportsOnAnimatorMove() { }

	[Address(RVA = "0x2FBFCD0", Offset = "0x2FBF0D0", Length = "0x33")]
	[Token(Token = "0x60001F1")]
	private static bool get_supportsOnAnimatorMove_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBFDE0", Offset = "0x2FBF1E0", Length = "0x90")]
	[Token(Token = "0x6000111")]
	public Vector3 get_targetPosition() { }

	[Address(RVA = "0x2FBFD90", Offset = "0x2FBF190", Length = "0x42")]
	[Token(Token = "0x60001BE")]
	private static void get_targetPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FBFED0", Offset = "0x2FBF2D0", Length = "0x8E")]
	[Token(Token = "0x6000112")]
	public Quaternion get_targetRotation() { }

	[Address(RVA = "0x2FBFE80", Offset = "0x2FBF280", Length = "0x42")]
	[Token(Token = "0x60001BF")]
	private static void get_targetRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x2FBFFA0", Offset = "0x2FBF3A0", Length = "0x76")]
	[Token(Token = "0x6000094")]
	public AnimatorUpdateMode get_updateMode() { }

	[Address(RVA = "0x2FBFF60", Offset = "0x2FBF360", Length = "0x33")]
	[Token(Token = "0x6000181")]
	private static AnimatorUpdateMode get_updateMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC0070", Offset = "0x2FBF470", Length = "0x90")]
	[Token(Token = "0x6000088")]
	public Vector3 get_velocity() { }

	[Address(RVA = "0x2FC0020", Offset = "0x2FBF420", Length = "0x42")]
	[Token(Token = "0x6000175")]
	private static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FC0150", Offset = "0x2FBF550", Length = "0x76")]
	[Token(Token = "0x6000162")]
	public bool get_writeDefaultValuesOnDisable() { }

	[Address(RVA = "0x2FC0110", Offset = "0x2FBF510", Length = "0x33")]
	[Token(Token = "0x6000201")]
	private static bool get_writeDefaultValuesOnDisable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FB5E30", Offset = "0x2FB5230", Length = "0x95")]
	[Token(Token = "0x60000D7")]
	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	[Address(RVA = "0x2FB5DD0", Offset = "0x2FB51D0", Length = "0x52")]
	[Token(Token = "0x60001A6")]
	private static int GetAnimatorClipInfoCount_Injected(IntPtr _unity_self, int layerIndex, bool current) { }

	[Address(RVA = "0x2FB5F40", Offset = "0x2FB5340", Length = "0xA9")]
	[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = True)]
	[Token(Token = "0x60000DD")]
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	[Address(RVA = "0x2FB5ED0", Offset = "0x2FB52D0", Length = "0x62")]
	[Token(Token = "0x60001A9")]
	private static void GetAnimatorClipInfoInternal_Injected(IntPtr _unity_self, int layerIndex, bool isCurrent, object clips) { }

	[Address(RVA = "0x2FB6050", Offset = "0x2FB5450", Length = "0xA7")]
	[Token(Token = "0x60000D2")]
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	[Address(RVA = "0x2FB5FF0", Offset = "0x2FB53F0", Length = "0x60")]
	[Token(Token = "0x60001A4")]
	private static void GetAnimatorStateInfo_Injected(IntPtr _unity_self, int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	[Address(RVA = "0x2FB6170", Offset = "0x2FB5570", Length = "0x128")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x6000158")]
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	[Address(RVA = "0x2FB6100", Offset = "0x2FB5500", Length = "0x62")]
	[Token(Token = "0x60001F9")]
	private static void GetAnimatorStateName_Injected(IntPtr _unity_self, int layerIndex, bool current, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FB6390", Offset = "0x2FB5790", Length = "0xC1")]
	[Token(Token = "0x60000D6")]
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	[Address(RVA = "0x2FB62F0", Offset = "0x2FB56F0", Length = "0x93")]
	[Token(Token = "0x60000D5")]
	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	[Address(RVA = "0x2FB62A0", Offset = "0x2FB56A0", Length = "0x50")]
	[Token(Token = "0x60001A5")]
	private static void GetAnimatorTransitionInfo_Injected(IntPtr _unity_self, int layerIndex, out AnimatorTransitionInfo info) { }

	[Address(RVA = "0x2FB64B0", Offset = "0x2FB58B0", Length = "0xC1")]
	[Token(Token = "0x60000C4")]
	private ScriptableObject GetBehaviour(Type type) { }

	[Address(RVA = "0x768890", Offset = "0x767C90", Length = "0x8E")]
	[Token(Token = "0x60000C5")]
	public T GetBehaviour() { }

	[Address(RVA = "0x2FB6460", Offset = "0x2FB5860", Length = "0x42")]
	[Token(Token = "0x600019A")]
	private static IntPtr GetBehaviour_Injected(IntPtr _unity_self, Type type) { }

	[Address(RVA = "0x2FB6580", Offset = "0x2FB5980", Length = "0x125")]
	[Token(Token = "0x60000C9")]
	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	[Address(RVA = "0x768920", Offset = "0x767D20", Length = "0x16C")]
	[Token(Token = "0x60000C7")]
	public T[] GetBehaviours() { }

	[Address(RVA = "0x2FB6790", Offset = "0x2FB5B90", Length = "0x4AB")]
	[Token(Token = "0x6000116")]
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[Address(RVA = "0x2FB66F0", Offset = "0x2FB5AF0", Length = "0x9D")]
	[NativeMethod("GetBoneTransform")]
	[Token(Token = "0x6000117")]
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	[Address(RVA = "0x2FB66B0", Offset = "0x2FB5AB0", Length = "0x40")]
	[Token(Token = "0x60001C2")]
	private static IntPtr GetBoneTransformInternal_Injected(IntPtr _unity_self, int humanBoneId) { }

	[Address(RVA = "0x2FB6C80", Offset = "0x2FB6080", Length = "0x83")]
	[Token(Token = "0x6000079")]
	public bool GetBool(int id) { }

	[Address(RVA = "0x2FB6F30", Offset = "0x2FB6330", Length = "0xA")]
	[Token(Token = "0x6000078")]
	public bool GetBool(string name) { }

	[Address(RVA = "0x2FB6C80", Offset = "0x2FB6080", Length = "0x83")]
	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = True)]
	[Token(Token = "0x600013B")]
	private bool GetBoolID(int id) { }

	[Address(RVA = "0x2FB6C40", Offset = "0x2FB6040", Length = "0x40")]
	[Token(Token = "0x60001E0")]
	private static bool GetBoolID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x2FB6D60", Offset = "0x2FB6160", Length = "0x1CE")]
	[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = True)]
	[Token(Token = "0x600013A")]
	private bool GetBoolString(string name) { }

	[Address(RVA = "0x2FB6D10", Offset = "0x2FB6110", Length = "0x42")]
	[Token(Token = "0x60001DF")]
	private static bool GetBoolString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x2FB7010", Offset = "0x2FB6410", Length = "0xE8")]
	[Token(Token = "0x60000DC")]
	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[Address(RVA = "0x2FB7100", Offset = "0x2FB6500", Length = "0x83")]
	[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = True)]
	[Token(Token = "0x60000DA")]
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[Address(RVA = "0x2FB6FD0", Offset = "0x2FB63D0", Length = "0x40")]
	[Token(Token = "0x60001A7")]
	private static AnimatorClipInfo[] GetCurrentAnimatorClipInfo_Injected(IntPtr _unity_self, int layerIndex) { }

	[Address(RVA = "0x2FB6F40", Offset = "0x2FB6340", Length = "0x86")]
	[Token(Token = "0x60000D8")]
	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	[Address(RVA = "0x2FB7190", Offset = "0x2FB6590", Length = "0xD3")]
	[Token(Token = "0x60000D3")]
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	[Address(RVA = "0x2FB72C0", Offset = "0x2FB66C0", Length = "0x85")]
	[FreeFunction(Name = "AnimatorBindings::GetCurrentGraph", HasExplicitThis = True)]
	[Token(Token = "0x6000131")]
	private void GetCurrentGraph(ref PlayableGraph graph) { }

	[Address(RVA = "0x2FB7270", Offset = "0x2FB6670", Length = "0x42")]
	[Token(Token = "0x60001D7")]
	private static void GetCurrentGraph_Injected(IntPtr _unity_self, ref PlayableGraph graph) { }

	[Address(RVA = "0x2FB7350", Offset = "0x2FB6750", Length = "0xD")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x6000156")]
	internal string GetCurrentStateName(int layerIndex) { }

	[Address(RVA = "0x2FB73A0", Offset = "0x2FB67A0", Length = "0x83")]
	[Token(Token = "0x6000073")]
	public float GetFloat(int id) { }

	[Address(RVA = "0x2FB7660", Offset = "0x2FB6A60", Length = "0xA")]
	[Token(Token = "0x6000072")]
	public float GetFloat(string name) { }

	[Address(RVA = "0x2FB73A0", Offset = "0x2FB67A0", Length = "0x83")]
	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = True)]
	[Token(Token = "0x6000137")]
	private float GetFloatID(int id) { }

	[Address(RVA = "0x2FB7360", Offset = "0x2FB6760", Length = "0x40")]
	[Token(Token = "0x60001DC")]
	private static float GetFloatID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x2FB7480", Offset = "0x2FB6880", Length = "0x1D1")]
	[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = True)]
	[Token(Token = "0x6000136")]
	private float GetFloatString(string name) { }

	[Address(RVA = "0x2FB7430", Offset = "0x2FB6830", Length = "0x42")]
	[Token(Token = "0x60001DB")]
	private static float GetFloatString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x2FB76C0", Offset = "0x2FB6AC0", Length = "0x9F")]
	[Token(Token = "0x60000A3")]
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB7670", Offset = "0x2FB6A70", Length = "0x50")]
	[Token(Token = "0x600018B")]
	private static void GetGoalPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, out Vector3 ret) { }

	[Address(RVA = "0x2FB77B0", Offset = "0x2FB6BB0", Length = "0x9D")]
	[Token(Token = "0x60000A7")]
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB7760", Offset = "0x2FB6B60", Length = "0x50")]
	[Token(Token = "0x600018D")]
	private static void GetGoalRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal, out Quaternion ret) { }

	[Address(RVA = "0x2FB7890", Offset = "0x2FB6C90", Length = "0x83")]
	[Token(Token = "0x60000AB")]
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB7850", Offset = "0x2FB6C50", Length = "0x40")]
	[Token(Token = "0x600018F")]
	private static float GetGoalWeightPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB7960", Offset = "0x2FB6D60", Length = "0x83")]
	[Token(Token = "0x60000AF")]
	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB7920", Offset = "0x2FB6D20", Length = "0x40")]
	[Token(Token = "0x6000191")]
	private static float GetGoalWeightRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB7A40", Offset = "0x2FB6E40", Length = "0x9F")]
	[Token(Token = "0x60000B3")]
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	[Address(RVA = "0x2FB79F0", Offset = "0x2FB6DF0", Length = "0x50")]
	[Token(Token = "0x6000193")]
	private static void GetHintPosition_Injected(IntPtr _unity_self, AvatarIKHint hint, out Vector3 ret) { }

	[Address(RVA = "0x2FB7B20", Offset = "0x2FB6F20", Length = "0x83")]
	[Token(Token = "0x60000B7")]
	private float GetHintWeightPosition(AvatarIKHint hint) { }

	[Address(RVA = "0x2FB7AE0", Offset = "0x2FB6EE0", Length = "0x40")]
	[Token(Token = "0x6000195")]
	private static float GetHintWeightPosition_Injected(IntPtr _unity_self, AvatarIKHint hint) { }

	[Address(RVA = "0x2FB7C40", Offset = "0x2FB7040", Length = "0xC7")]
	[Token(Token = "0x60000B2")]
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	[Address(RVA = "0x2FB7BB0", Offset = "0x2FB6FB0", Length = "0x8A")]
	[Token(Token = "0x60000B6")]
	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	[Address(RVA = "0x2FB7DA0", Offset = "0x2FB71A0", Length = "0xC7")]
	[Token(Token = "0x60000A2")]
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB7D10", Offset = "0x2FB7110", Length = "0x8A")]
	[Token(Token = "0x60000AA")]
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB7F00", Offset = "0x2FB7300", Length = "0xB9")]
	[Token(Token = "0x60000A6")]
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB7E70", Offset = "0x2FB7270", Length = "0x8A")]
	[Token(Token = "0x60000AE")]
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	[Address(RVA = "0x2FB8000", Offset = "0x2FB7400", Length = "0x83")]
	[Token(Token = "0x600007D")]
	public int GetInteger(int id) { }

	[Address(RVA = "0x2FB82B0", Offset = "0x2FB76B0", Length = "0xA")]
	[Token(Token = "0x600007C")]
	public int GetInteger(string name) { }

	[Address(RVA = "0x2FB8000", Offset = "0x2FB7400", Length = "0x83")]
	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = True)]
	[Token(Token = "0x600013F")]
	private int GetIntegerID(int id) { }

	[Address(RVA = "0x2FB7FC0", Offset = "0x2FB73C0", Length = "0x40")]
	[Token(Token = "0x60001E4")]
	private static int GetIntegerID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x2FB80E0", Offset = "0x2FB74E0", Length = "0x1CD")]
	[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = True)]
	[Token(Token = "0x600013E")]
	private int GetIntegerString(string name) { }

	[Address(RVA = "0x2FB8090", Offset = "0x2FB7490", Length = "0x42")]
	[Token(Token = "0x60001E3")]
	private static int GetIntegerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x2FB8310", Offset = "0x2FB7710", Length = "0x1CD")]
	[Token(Token = "0x60000CF")]
	public int GetLayerIndex(string layerName) { }

	[Address(RVA = "0x2FB82C0", Offset = "0x2FB76C0", Length = "0x42")]
	[Token(Token = "0x60001A1")]
	private static int GetLayerIndex_Injected(IntPtr _unity_self, ref ManagedSpanWrapper layerName) { }

	[Address(RVA = "0x2FB8530", Offset = "0x2FB7930", Length = "0x113")]
	[Token(Token = "0x60000CE")]
	public string GetLayerName(int layerIndex) { }

	[Address(RVA = "0x2FB84E0", Offset = "0x2FB78E0", Length = "0x50")]
	[Token(Token = "0x60001A0")]
	private static void GetLayerName_Injected(IntPtr _unity_self, int layerIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FB8690", Offset = "0x2FB7A90", Length = "0x83")]
	[Token(Token = "0x60000D0")]
	public float GetLayerWeight(int layerIndex) { }

	[Address(RVA = "0x2FB8650", Offset = "0x2FB7A50", Length = "0x40")]
	[Token(Token = "0x60001A2")]
	private static float GetLayerWeight_Injected(IntPtr _unity_self, int layerIndex) { }

	[Address(RVA = "0x2FB87F0", Offset = "0x2FB7BF0", Length = "0xE8")]
	[Token(Token = "0x60000DE")]
	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[Address(RVA = "0x2FB88E0", Offset = "0x2FB7CE0", Length = "0x83")]
	[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = True)]
	[Token(Token = "0x60000DB")]
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	[Address(RVA = "0x2FB87B0", Offset = "0x2FB7BB0", Length = "0x40")]
	[Token(Token = "0x60001A8")]
	private static AnimatorClipInfo[] GetNextAnimatorClipInfo_Injected(IntPtr _unity_self, int layerIndex) { }

	[Address(RVA = "0x2FB8720", Offset = "0x2FB7B20", Length = "0x86")]
	[Token(Token = "0x60000D9")]
	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	[Address(RVA = "0x2FB8970", Offset = "0x2FB7D70", Length = "0xD6")]
	[Token(Token = "0x60000D4")]
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[Address(RVA = "0x2FB8A50", Offset = "0x2FB7E50", Length = "0xD")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x6000157")]
	internal string GetNextStateName(int layerIndex) { }

	[Address(RVA = "0x2FB8B30", Offset = "0x2FB7F30", Length = "0x115")]
	[Token(Token = "0x60000E3")]
	public AnimatorControllerParameter GetParameter(int index) { }

	[Address(RVA = "0x2FB8AA0", Offset = "0x2FB7EA0", Length = "0x83")]
	[FreeFunction(Name = "AnimatorBindings::GetParameterInternal", HasExplicitThis = True)]
	[Token(Token = "0x60000E2")]
	private AnimatorControllerParameter GetParameterInternal(int index) { }

	[Address(RVA = "0x2FB8A60", Offset = "0x2FB7E60", Length = "0x40")]
	[Token(Token = "0x60001AD")]
	private static AnimatorControllerParameter GetParameterInternal_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x2FB8C50", Offset = "0x2FB8050", Length = "0x48")]
	[Obsolete("GetQuaternion is deprecated.")]
	[Token(Token = "0x6000169")]
	public Quaternion GetQuaternion(int id) { }

	[Address(RVA = "0x2FB8C50", Offset = "0x2FB8050", Length = "0x48")]
	[Obsolete("GetQuaternion is deprecated.")]
	[Token(Token = "0x6000168")]
	public Quaternion GetQuaternion(string name) { }

	[Address(RVA = "0x2FB8CE0", Offset = "0x2FB80E0", Length = "0x76")]
	[Token(Token = "0x6000122")]
	private float GetRecorderStartTime() { }

	[Address(RVA = "0x2FB8CA0", Offset = "0x2FB80A0", Length = "0x33")]
	[Token(Token = "0x60001CB")]
	private static float GetRecorderStartTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FB8DA0", Offset = "0x2FB81A0", Length = "0x76")]
	[Token(Token = "0x6000125")]
	private float GetRecorderStopTime() { }

	[Address(RVA = "0x2FB8D60", Offset = "0x2FB8160", Length = "0x33")]
	[Token(Token = "0x60001CC")]
	private static float GetRecorderStopTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FB8E70", Offset = "0x2FB8270", Length = "0x106")]
	[Token(Token = "0x600012F")]
	internal string GetStats() { }

	[Address(RVA = "0x2FB8E20", Offset = "0x2FB8220", Length = "0x42")]
	[Token(Token = "0x60001D6")]
	private static void GetStats_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FB8F80", Offset = "0x2FB8380", Length = "0x51")]
	[Obsolete("GetVector is deprecated.")]
	[Token(Token = "0x6000165")]
	public Vector3 GetVector(int id) { }

	[Address(RVA = "0x2FB8F80", Offset = "0x2FB8380", Length = "0x51")]
	[Obsolete("GetVector is deprecated.")]
	[Token(Token = "0x6000164")]
	public Vector3 GetVector(string name) { }

	[Address(RVA = "0x2FB9030", Offset = "0x2FB8430", Length = "0x93")]
	[Token(Token = "0x600012B")]
	public bool HasState(int layerIndex, int stateID) { }

	[Address(RVA = "0x2FB8FE0", Offset = "0x2FB83E0", Length = "0x50")]
	[Token(Token = "0x60001D2")]
	private static bool HasState_Injected(IntPtr _unity_self, int layerIndex, int stateID) { }

	[Address(RVA = "0x2FB9250", Offset = "0x2FB8650", Length = "0xA7")]
	[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = True)]
	[Token(Token = "0x60000C8")]
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	[Address(RVA = "0x2FB9200", Offset = "0x2FB8600", Length = "0x42")]
	[Token(Token = "0x600019B")]
	private static ScriptableObject[] InternalGetBehaviours_Injected(IntPtr _unity_self, Type type) { }

	[Address(RVA = "0x2FB9130", Offset = "0x2FB8530", Length = "0xC9")]
	[FreeFunction(Name = "AnimatorBindings::InternalGetBehavioursByKey", HasExplicitThis = True)]
	[Token(Token = "0x60000CA")]
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	[Address(RVA = "0x2FB90D0", Offset = "0x2FB84D0", Length = "0x60")]
	[Token(Token = "0x600019C")]
	private static ScriptableObject[] InternalGetBehavioursByKey_Injected(IntPtr _unity_self, int fullPathHash, int layerIndex, Type type) { }

	[Address(RVA = "0x2FB9350", Offset = "0x2FB8750", Length = "0x86")]
	[Token(Token = "0x60000ED")]
	public void InterruptMatchTarget(bool completeMatch) { }

	[Address(RVA = "0x2FB93E0", Offset = "0x2FB87E0", Length = "0x78")]
	[Token(Token = "0x60000EC")]
	public void InterruptMatchTarget() { }

	[Address(RVA = "0x2FB9300", Offset = "0x2FB8700", Length = "0x42")]
	[Token(Token = "0x60001B3")]
	private static void InterruptMatchTarget_Injected(IntPtr _unity_self, bool completeMatch) { }

	[Address(RVA = "0x2FB94B0", Offset = "0x2FB88B0", Length = "0xBA")]
	[Token(Token = "0x6000114")]
	internal bool IsBoneTransform(Transform transform) { }

	[Address(RVA = "0x2FB9460", Offset = "0x2FB8860", Length = "0x42")]
	[Token(Token = "0x60001C0")]
	private static bool IsBoneTransform_Injected(IntPtr _unity_self, IntPtr transform) { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", True)]
	[Token(Token = "0x6000113")]
	public bool IsControlled(Transform transform) { }

	[Address(RVA = "0x2FB95B0", Offset = "0x2FB89B0", Length = "0x76")]
	[Token(Token = "0x6000133")]
	private bool IsInIKPass() { }

	[Address(RVA = "0x2FB9570", Offset = "0x2FB8970", Length = "0x33")]
	[Token(Token = "0x60001D8")]
	private static bool IsInIKPass_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FB9670", Offset = "0x2FB8A70", Length = "0x83")]
	[Token(Token = "0x60000DF")]
	public bool IsInTransition(int layerIndex) { }

	[Address(RVA = "0x2FB9630", Offset = "0x2FB8A30", Length = "0x40")]
	[Token(Token = "0x60001AA")]
	private static bool IsInTransition_Injected(IntPtr _unity_self, int layerIndex) { }

	[Address(RVA = "0x2FB9740", Offset = "0x2FB8B40", Length = "0x83")]
	[Token(Token = "0x6000085")]
	public bool IsParameterControlledByCurve(int id) { }

	[Address(RVA = "0x2FB99F0", Offset = "0x2FB8DF0", Length = "0xA")]
	[Token(Token = "0x6000084")]
	public bool IsParameterControlledByCurve(string name) { }

	[Address(RVA = "0x2FB9740", Offset = "0x2FB8B40", Length = "0x83")]
	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = True)]
	[Token(Token = "0x6000145")]
	private bool IsParameterControlledByCurveID(int id) { }

	[Address(RVA = "0x2FB9700", Offset = "0x2FB8B00", Length = "0x40")]
	[Token(Token = "0x60001EA")]
	private static bool IsParameterControlledByCurveID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x2FB9820", Offset = "0x2FB8C20", Length = "0x1CE")]
	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = True)]
	[Token(Token = "0x6000144")]
	private bool IsParameterControlledByCurveString(string name) { }

	[Address(RVA = "0x2FB97D0", Offset = "0x2FB8BD0", Length = "0x42")]
	[Token(Token = "0x60001E9")]
	private static bool IsParameterControlledByCurveString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x2FB9D60", Offset = "0x2FB9160", Length = "0xFA")]
	[Token(Token = "0x60000EB")]
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	[Address(RVA = "0x2FB9C80", Offset = "0x2FB9080", Length = "0xDC")]
	[Token(Token = "0x60000E8")]
	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	[Address(RVA = "0x2FB9B80", Offset = "0x2FB8F80", Length = "0xF2")]
	[Token(Token = "0x60000E9")]
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	[Address(RVA = "0x2FB9A80", Offset = "0x2FB8E80", Length = "0xF3")]
	[Token(Token = "0x60000EA")]
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	[Address(RVA = "0x2FB9A00", Offset = "0x2FB8E00", Length = "0x73")]
	[Token(Token = "0x60001B2")]
	private static void MatchTarget_Injected(IntPtr _unity_self, in Vector3 matchPosition, in Quaternion matchRotation, int targetBodyPart, in MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	[Address(RVA = "0x2FB9EA0", Offset = "0x2FB92A0", Length = "0x76")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x600014E")]
	internal void OnCullingModeChanged() { }

	[Address(RVA = "0x2FB9E60", Offset = "0x2FB9260", Length = "0x33")]
	[Token(Token = "0x60001F3")]
	private static void OnCullingModeChanged_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FB9F60", Offset = "0x2FB9360", Length = "0x76")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x600014D")]
	internal void OnUpdateModeChanged() { }

	[Address(RVA = "0x2FB9F20", Offset = "0x2FB9320", Length = "0x33")]
	[Token(Token = "0x60001F2")]
	private static void OnUpdateModeChanged_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBA5F0", Offset = "0x2FB99F0", Length = "0xB0")]
	[Token(Token = "0x600010B")]
	public void Play(string stateName, int layer, float normalizedTime) { }

	[Address(RVA = "0x2FBA800", Offset = "0x2FB9C00", Length = "0x91")]
	[Token(Token = "0x600010E")]
	public void Play(int stateNameHash) { }

	[Address(RVA = "0x2FBA4A0", Offset = "0x2FB98A0", Length = "0x9E")]
	[Token(Token = "0x600010A")]
	public void Play(string stateName) { }

	[Address(RVA = "0x2FBA760", Offset = "0x2FB9B60", Length = "0x9B")]
	[Token(Token = "0x600010D")]
	public void Play(int stateNameHash, int layer) { }

	[Address(RVA = "0x2FBA540", Offset = "0x2FB9940", Length = "0xA3")]
	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	[Token(Token = "0x600010C")]
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	[Address(RVA = "0x2FBA6B0", Offset = "0x2FB9AB0", Length = "0xA8")]
	[Token(Token = "0x6000109")]
	public void Play(string stateName, int layer) { }

	[Address(RVA = "0x2FBA440", Offset = "0x2FB9840", Length = "0x60")]
	[Token(Token = "0x60001BB")]
	private static void Play_Injected(IntPtr _unity_self, int stateNameHash, int layer, float normalizedTime) { }

	[Address(RVA = "0x2FBA040", Offset = "0x2FB9440", Length = "0x9B")]
	[Token(Token = "0x6000107")]
	public void PlayInFixedTime(int stateNameHash, int layer) { }

	[Address(RVA = "0x2FBA2F0", Offset = "0x2FB96F0", Length = "0xA3")]
	[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = True)]
	[Token(Token = "0x6000106")]
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	[Address(RVA = "0x2FBA180", Offset = "0x2FB9580", Length = "0xB0")]
	[Token(Token = "0x6000105")]
	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	[Address(RVA = "0x2FBA0E0", Offset = "0x2FB94E0", Length = "0x9E")]
	[Token(Token = "0x6000104")]
	public void PlayInFixedTime(string stateName) { }

	[Address(RVA = "0x2FBA240", Offset = "0x2FB9640", Length = "0xA8")]
	[Token(Token = "0x6000103")]
	public void PlayInFixedTime(string stateName, int layer) { }

	[Address(RVA = "0x2FBA3A0", Offset = "0x2FB97A0", Length = "0x91")]
	[Token(Token = "0x6000108")]
	public void PlayInFixedTime(int stateNameHash) { }

	[Address(RVA = "0x2FB9FE0", Offset = "0x2FB93E0", Length = "0x60")]
	[Token(Token = "0x60001BA")]
	private static void PlayInFixedTime_Injected(IntPtr _unity_self, int stateNameHash, int layer, float fixedTime) { }

	[Address(RVA = "0x2FBA8F0", Offset = "0x2FB9CF0", Length = "0x78")]
	[Token(Token = "0x6000151")]
	public void Rebind() { }

	[Address(RVA = "0x2FBA970", Offset = "0x2FB9D70", Length = "0x86")]
	[Token(Token = "0x6000152")]
	private void Rebind(bool writeDefaultValues) { }

	[Address(RVA = "0x2FBA8A0", Offset = "0x2FB9CA0", Length = "0x42")]
	[Token(Token = "0x60001F6")]
	private static void Rebind_Injected(IntPtr _unity_self, bool writeDefaultValues) { }

	[Address(RVA = "0x2FBAA50", Offset = "0x2FB9E50", Length = "0x86")]
	[Token(Token = "0x600010F")]
	public void ResetControllerState(bool resetParameters = true) { }

	[Address(RVA = "0x2FBAA00", Offset = "0x2FB9E00", Length = "0x42")]
	[Token(Token = "0x60001BC")]
	private static void ResetControllerState_Injected(IntPtr _unity_self, bool resetParameters) { }

	[Address(RVA = "0x2FBAB20", Offset = "0x2FB9F20", Length = "0x83")]
	[Token(Token = "0x6000083")]
	public void ResetTrigger(int id) { }

	[Address(RVA = "0x2FBADD0", Offset = "0x2FBA1D0", Length = "0x8")]
	[Token(Token = "0x6000082")]
	public void ResetTrigger(string name) { }

	[Address(RVA = "0x2FBAB20", Offset = "0x2FB9F20", Length = "0x83")]
	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = True)]
	[Token(Token = "0x6000143")]
	private void ResetTriggerID(int id) { }

	[Address(RVA = "0x2FBAAE0", Offset = "0x2FB9EE0", Length = "0x40")]
	[Token(Token = "0x60001E8")]
	private static void ResetTriggerID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x2FBAC00", Offset = "0x2FBA000", Length = "0x1C7")]
	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	[Token(Token = "0x6000142")]
	private void ResetTriggerString(string name) { }

	[Address(RVA = "0x2FBABB0", Offset = "0x2FB9FB0", Length = "0x42")]
	[Token(Token = "0x60001E7")]
	private static void ResetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x2FBAE30", Offset = "0x2FBA230", Length = "0x113")]
	[Token(Token = "0x6000159")]
	internal string ResolveHash(int hash) { }

	[Address(RVA = "0x2FBADE0", Offset = "0x2FBA1E0", Length = "0x50")]
	[Token(Token = "0x60001FA")]
	private static void ResolveHash_Injected(IntPtr _unity_self, int hash, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FC0220", Offset = "0x2FBF620", Length = "0x86")]
	[Token(Token = "0x6000098")]
	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	[Address(RVA = "0x2FC01D0", Offset = "0x2FBF5D0", Length = "0x42")]
	[Token(Token = "0x6000185")]
	private static void set_allowConstantClipSamplingOptimization_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC0300", Offset = "0x2FBF700", Length = "0x86")]
	[Token(Token = "0x6000093")]
	public void set_animatePhysics(bool value) { }

	[Address(RVA = "0x2FC02B0", Offset = "0x2FBF6B0", Length = "0x42")]
	[Token(Token = "0x6000180")]
	private static void set_animatePhysics_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC03E0", Offset = "0x2FBF7E0", Length = "0x86")]
	[Token(Token = "0x600008F")]
	public void set_applyRootMotion(bool value) { }

	[Address(RVA = "0x2FC0390", Offset = "0x2FBF790", Length = "0x42")]
	[Token(Token = "0x600017C")]
	private static void set_applyRootMotion_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC04C0", Offset = "0x2FBF8C0", Length = "0xBA")]
	[Token(Token = "0x600012E")]
	public void set_avatar(Avatar value) { }

	[Address(RVA = "0x2FC0470", Offset = "0x2FBF870", Length = "0x42")]
	[Token(Token = "0x60001D5")]
	private static void set_avatar_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FC0660", Offset = "0x2FBFA60", Length = "0x95")]
	[Token(Token = "0x600009B")]
	public void set_bodyPosition(Vector3 value) { }

	[Address(RVA = "0x2FC05D0", Offset = "0x2FBF9D0", Length = "0x85")]
	[NativeMethod("SetBodyPosition")]
	[Token(Token = "0x600009D")]
	internal void set_bodyPositionInternal(Vector3 value) { }

	[Address(RVA = "0x2FC0580", Offset = "0x2FBF980", Length = "0x42")]
	[Token(Token = "0x6000188")]
	private static void set_bodyPositionInternal_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FC07E0", Offset = "0x2FBFBE0", Length = "0x8C")]
	[Token(Token = "0x600009F")]
	public void set_bodyRotation(Quaternion value) { }

	[Address(RVA = "0x2FC0750", Offset = "0x2FBFB50", Length = "0x85")]
	[NativeMethod("SetBodyRotation")]
	[Token(Token = "0x60000A1")]
	internal void set_bodyRotationInternal(Quaternion value) { }

	[Address(RVA = "0x2FC0700", Offset = "0x2FBFB00", Length = "0x42")]
	[Token(Token = "0x600018A")]
	private static void set_bodyRotationInternal_Injected(IntPtr _unity_self, in Quaternion value) { }

	[Address(RVA = "0x2FC08B0", Offset = "0x2FBFCB0", Length = "0x83")]
	[Token(Token = "0x6000119")]
	public void set_cullingMode(AnimatorCullingMode value) { }

	[Address(RVA = "0x2FC0870", Offset = "0x2FBFC70", Length = "0x40")]
	[Token(Token = "0x60001C4")]
	private static void set_cullingMode_Injected(IntPtr _unity_self, AnimatorCullingMode value) { }

	[Address(RVA = "0x2FC0990", Offset = "0x2FBFD90", Length = "0x86")]
	[Token(Token = "0x60000E5")]
	public void set_feetPivotActive(float value) { }

	[Address(RVA = "0x2FC0940", Offset = "0x2FBFD40", Length = "0x43")]
	[Token(Token = "0x60001AF")]
	private static void set_feetPivotActive_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FC0A70", Offset = "0x2FBFE70", Length = "0x86")]
	[Token(Token = "0x600015D")]
	public void set_fireEvents(bool value) { }

	[Address(RVA = "0x2FC0A20", Offset = "0x2FBFE20", Length = "0x42")]
	[Token(Token = "0x60001FE")]
	private static void set_fireEvents_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC0B00", Offset = "0x2FBFF00", Length = "0x86")]
	[Token(Token = "0x600015F")]
	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	[Address(RVA = "0x2FC0B00", Offset = "0x2FBFF00", Length = "0x86")]
	[Token(Token = "0x6000161")]
	public void set_keepAnimatorStateOnDisable(bool value) { }

	[Address(RVA = "0x2FC0B90", Offset = "0x2FBFF90", Length = "0x42")]
	[Token(Token = "0x6000200")]
	private static void set_keepAnimatorStateOnDisable_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC0C30", Offset = "0x2FC0030", Length = "0x86")]
	[Token(Token = "0x6000149")]
	public void set_layersAffectMassCenter(bool value) { }

	[Address(RVA = "0x2FC0BE0", Offset = "0x2FBFFE0", Length = "0x42")]
	[Token(Token = "0x60001EE")]
	private static void set_layersAffectMassCenter_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC0D10", Offset = "0x2FC0110", Length = "0x86")]
	[Token(Token = "0x6000091")]
	public void set_linearVelocityBlending(bool value) { }

	[Address(RVA = "0x2FC0CC0", Offset = "0x2FC00C0", Length = "0x42")]
	[Token(Token = "0x600017E")]
	private static void set_linearVelocityBlending_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC0DF0", Offset = "0x2FC01F0", Length = "0x86")]
	[Token(Token = "0x600015B")]
	public void set_logWarnings(bool value) { }

	[Address(RVA = "0x2FC0DA0", Offset = "0x2FC01A0", Length = "0x42")]
	[Token(Token = "0x60001FC")]
	private static void set_logWarnings_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC0ED0", Offset = "0x2FC02D0", Length = "0x86")]
	[Token(Token = "0x600011D")]
	public void set_playbackTime(float value) { }

	[Address(RVA = "0x2FC0E80", Offset = "0x2FC0280", Length = "0x43")]
	[Token(Token = "0x60001C8")]
	private static void set_playbackTime_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000121")]
	public void set_recorderStartTime(float value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000124")]
	public void set_recorderStopTime(float value) { }

	[Address(RVA = "0x2FC0FB0", Offset = "0x2FC03B0", Length = "0x85")]
	[NativeMethod("SetAvatarPosition")]
	[Token(Token = "0x600008B")]
	public void set_rootPosition(Vector3 value) { }

	[Address(RVA = "0x2FC0F60", Offset = "0x2FC0360", Length = "0x42")]
	[Token(Token = "0x6000178")]
	private static void set_rootPosition_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FC1090", Offset = "0x2FC0490", Length = "0x85")]
	[NativeMethod("SetAvatarRotation")]
	[Token(Token = "0x600008D")]
	public void set_rootRotation(Quaternion value) { }

	[Address(RVA = "0x2FC1040", Offset = "0x2FC0440", Length = "0x42")]
	[Token(Token = "0x600017A")]
	private static void set_rootRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	[Address(RVA = "0x2FC1170", Offset = "0x2FC0570", Length = "0xBA")]
	[Token(Token = "0x6000128")]
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[Address(RVA = "0x2FC1120", Offset = "0x2FC0520", Length = "0x42")]
	[Token(Token = "0x60001CF")]
	private static void set_runtimeAnimatorController_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FC1280", Offset = "0x2FC0680", Length = "0x86")]
	[Token(Token = "0x60000F0")]
	public void set_speed(float value) { }

	[Address(RVA = "0x2FC1230", Offset = "0x2FC0630", Length = "0x43")]
	[Token(Token = "0x60001B6")]
	private static void set_speed_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FC1360", Offset = "0x2FC0760", Length = "0x86")]
	[Token(Token = "0x60000CC")]
	public void set_stabilizeFeet(bool value) { }

	[Address(RVA = "0x2FC1310", Offset = "0x2FC0710", Length = "0x42")]
	[Token(Token = "0x600019E")]
	private static void set_stabilizeFeet_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FC1430", Offset = "0x2FC0830", Length = "0x83")]
	[Token(Token = "0x6000095")]
	public void set_updateMode(AnimatorUpdateMode value) { }

	[Address(RVA = "0x2FC13F0", Offset = "0x2FC07F0", Length = "0x40")]
	[Token(Token = "0x6000182")]
	private static void set_updateMode_Injected(IntPtr _unity_self, AnimatorUpdateMode value) { }

	[Address(RVA = "0x2FC1510", Offset = "0x2FC0910", Length = "0x86")]
	[Token(Token = "0x6000163")]
	public void set_writeDefaultValuesOnDisable(bool value) { }

	[Address(RVA = "0x2FC14C0", Offset = "0x2FC08C0", Length = "0x42")]
	[Token(Token = "0x6000202")]
	private static void set_writeDefaultValuesOnDisable_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FBB040", Offset = "0x2FBA440", Length = "0xBF")]
	[Token(Token = "0x60000C2")]
	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	[Address(RVA = "0x2FBAFA0", Offset = "0x2FBA3A0", Length = "0x93")]
	[NativeMethod("SetBoneLocalRotation")]
	[Token(Token = "0x60000C3")]
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	[Address(RVA = "0x2FBAF50", Offset = "0x2FBA350", Length = "0x50")]
	[Token(Token = "0x6000199")]
	private static void SetBoneLocalRotationInternal_Injected(IntPtr _unity_self, int humanBoneId, in Quaternion rotation) { }

	[Address(RVA = "0x2FBB160", Offset = "0x2FBA560", Length = "0x95")]
	[Token(Token = "0x600007B")]
	public void SetBool(int id, bool value) { }

	[Address(RVA = "0x2FBB430", Offset = "0x2FBA830", Length = "0x8")]
	[Token(Token = "0x600007A")]
	public void SetBool(string name, bool value) { }

	[Address(RVA = "0x2FBB160", Offset = "0x2FBA560", Length = "0x95")]
	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = True)]
	[Token(Token = "0x6000139")]
	private void SetBoolID(int id, bool value) { }

	[Address(RVA = "0x2FBB100", Offset = "0x2FBA500", Length = "0x52")]
	[Token(Token = "0x60001DE")]
	private static void SetBoolID_Injected(IntPtr _unity_self, int id, bool value) { }

	[Address(RVA = "0x2FBB260", Offset = "0x2FBA660", Length = "0x1CC")]
	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	[Token(Token = "0x6000138")]
	private void SetBoolString(string name, bool value) { }

	[Address(RVA = "0x2FBB200", Offset = "0x2FBA600", Length = "0x54")]
	[Token(Token = "0x60001DD")]
	private static void SetBoolString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, bool value) { }

	[Address(RVA = "0x2FBB4A0", Offset = "0x2FBA8A0", Length = "0xA3")]
	[Token(Token = "0x6000077")]
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2FBB5A0", Offset = "0x2FBA9A0", Length = "0x93")]
	[Token(Token = "0x6000076")]
	public void SetFloat(int id, float value) { }

	[Address(RVA = "0x2FBBAF0", Offset = "0x2FBAEF0", Length = "0xE")]
	[Token(Token = "0x6000075")]
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2FBBB00", Offset = "0x2FBAF00", Length = "0x8")]
	[Token(Token = "0x6000074")]
	public void SetFloat(string name, float value) { }

	[Address(RVA = "0x2FBB5A0", Offset = "0x2FBA9A0", Length = "0x93")]
	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = True)]
	[Token(Token = "0x6000135")]
	private void SetFloatID(int id, float value) { }

	[Address(RVA = "0x2FBB550", Offset = "0x2FBA950", Length = "0x50")]
	[Token(Token = "0x60001DA")]
	private static void SetFloatID_Injected(IntPtr _unity_self, int id, float value) { }

	[Address(RVA = "0x2FBB4A0", Offset = "0x2FBA8A0", Length = "0xA3")]
	[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = True)]
	[Token(Token = "0x6000147")]
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2FBB440", Offset = "0x2FBA840", Length = "0x60")]
	[Token(Token = "0x60001EC")]
	private static void SetFloatIDDamp_Injected(IntPtr _unity_self, int id, float value, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2FBB910", Offset = "0x2FBAD10", Length = "0x1DD")]
	[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = True)]
	[Token(Token = "0x6000134")]
	private void SetFloatString(string name, float value) { }

	[Address(RVA = "0x2FBB8B0", Offset = "0x2FBACB0", Length = "0x52")]
	[Token(Token = "0x60001D9")]
	private static void SetFloatString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value) { }

	[Address(RVA = "0x2FBB6B0", Offset = "0x2FBAAB0", Length = "0x1FA")]
	[FreeFunction(Name = "AnimatorBindings::SetFloatStringDamp", HasExplicitThis = True)]
	[Token(Token = "0x6000146")]
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2FBB640", Offset = "0x2FBAA40", Length = "0x62")]
	[Token(Token = "0x60001EB")]
	private static void SetFloatStringDamp_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2FBBB60", Offset = "0x2FBAF60", Length = "0x93")]
	[Token(Token = "0x60000A5")]
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	[Address(RVA = "0x2FBBB10", Offset = "0x2FBAF10", Length = "0x50")]
	[Token(Token = "0x600018C")]
	private static void SetGoalPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, in Vector3 goalPosition) { }

	[Address(RVA = "0x2FBBC50", Offset = "0x2FBB050", Length = "0x93")]
	[Token(Token = "0x60000A9")]
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	[Address(RVA = "0x2FBBC00", Offset = "0x2FBB000", Length = "0x50")]
	[Token(Token = "0x600018E")]
	private static void SetGoalRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal, in Quaternion goalRotation) { }

	[Address(RVA = "0x2FBBD40", Offset = "0x2FBB140", Length = "0x93")]
	[Token(Token = "0x60000AD")]
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	[Address(RVA = "0x2FBBCF0", Offset = "0x2FBB0F0", Length = "0x50")]
	[Token(Token = "0x6000190")]
	private static void SetGoalWeightPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, float value) { }

	[Address(RVA = "0x2FBBE30", Offset = "0x2FBB230", Length = "0x93")]
	[Token(Token = "0x60000B1")]
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	[Address(RVA = "0x2FBBDE0", Offset = "0x2FBB1E0", Length = "0x50")]
	[Token(Token = "0x6000192")]
	private static void SetGoalWeightRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal, float value) { }

	[Address(RVA = "0x2FBBF20", Offset = "0x2FBB320", Length = "0x93")]
	[Token(Token = "0x60000B5")]
	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	[Address(RVA = "0x2FBBED0", Offset = "0x2FBB2D0", Length = "0x50")]
	[Token(Token = "0x6000194")]
	private static void SetHintPosition_Injected(IntPtr _unity_self, AvatarIKHint hint, in Vector3 hintPosition) { }

	[Address(RVA = "0x2FBC010", Offset = "0x2FBB410", Length = "0x93")]
	[Token(Token = "0x60000B9")]
	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	[Address(RVA = "0x2FBBFC0", Offset = "0x2FBB3C0", Length = "0x50")]
	[Token(Token = "0x6000196")]
	private static void SetHintWeightPosition_Injected(IntPtr _unity_self, AvatarIKHint hint, float value) { }

	[Address(RVA = "0x2FBC150", Offset = "0x2FBB550", Length = "0xA3")]
	[Token(Token = "0x60000B4")]
	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	[Address(RVA = "0x2FBC0B0", Offset = "0x2FBB4B0", Length = "0x9A")]
	[Token(Token = "0x60000B8")]
	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	[Address(RVA = "0x2FBC2A0", Offset = "0x2FBB6A0", Length = "0xA3")]
	[Token(Token = "0x60000A4")]
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	[Address(RVA = "0x2FBC200", Offset = "0x2FBB600", Length = "0x9A")]
	[Token(Token = "0x60000AC")]
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	[Address(RVA = "0x2FBC3F0", Offset = "0x2FBB7F0", Length = "0x9A")]
	[Token(Token = "0x60000A8")]
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	[Address(RVA = "0x2FBC350", Offset = "0x2FBB750", Length = "0x9A")]
	[Token(Token = "0x60000B0")]
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	[Address(RVA = "0x2FBC4E0", Offset = "0x2FBB8E0", Length = "0x93")]
	[Token(Token = "0x600007F")]
	public void SetInteger(int id, int value) { }

	[Address(RVA = "0x2FBC7B0", Offset = "0x2FBBBB0", Length = "0x8")]
	[Token(Token = "0x600007E")]
	public void SetInteger(string name, int value) { }

	[Address(RVA = "0x2FBC4E0", Offset = "0x2FBB8E0", Length = "0x93")]
	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = True)]
	[Token(Token = "0x600013D")]
	private void SetIntegerID(int id, int value) { }

	[Address(RVA = "0x2FBC490", Offset = "0x2FBB890", Length = "0x50")]
	[Token(Token = "0x60001E2")]
	private static void SetIntegerID_Injected(IntPtr _unity_self, int id, int value) { }

	[Address(RVA = "0x2FBC5E0", Offset = "0x2FBB9E0", Length = "0x1CA")]
	[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = True)]
	[Token(Token = "0x600013C")]
	private void SetIntegerString(string name, int value) { }

	[Address(RVA = "0x2FBC580", Offset = "0x2FBB980", Length = "0x52")]
	[Token(Token = "0x60001E1")]
	private static void SetIntegerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, int value) { }

	[Address(RVA = "0x2FBC810", Offset = "0x2FBBC10", Length = "0x93")]
	[Token(Token = "0x60000D1")]
	public void SetLayerWeight(int layerIndex, float weight) { }

	[Address(RVA = "0x2FBC7C0", Offset = "0x2FBBBC0", Length = "0x50")]
	[Token(Token = "0x60001A3")]
	private static void SetLayerWeight_Injected(IntPtr _unity_self, int layerIndex, float weight) { }

	[Address(RVA = "0x2FBC990", Offset = "0x2FBBD90", Length = "0x95")]
	[Token(Token = "0x60000BA")]
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[Address(RVA = "0x2FBC900", Offset = "0x2FBBD00", Length = "0x85")]
	[NativeMethod("SetLookAtPosition")]
	[Token(Token = "0x60000BB")]
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	[Address(RVA = "0x2FBC8B0", Offset = "0x2FBBCB0", Length = "0x42")]
	[Token(Token = "0x6000197")]
	private static void SetLookAtPositionInternal_Injected(IntPtr _unity_self, in Vector3 lookAtPosition) { }

	[Address(RVA = "0x2FBCCE0", Offset = "0x2FBC0E0", Length = "0xB1")]
	[Token(Token = "0x60000C0")]
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[Address(RVA = "0x2FBCC10", Offset = "0x2FBC010", Length = "0xC2")]
	[Token(Token = "0x60000BF")]
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	[Address(RVA = "0x2FBCB50", Offset = "0x2FBBF50", Length = "0xBC")]
	[Token(Token = "0x60000BD")]
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	[Address(RVA = "0x2FBCE70", Offset = "0x2FBC270", Length = "0xAC")]
	[Token(Token = "0x60000BC")]
	public void SetLookAtWeight(float weight) { }

	[Address(RVA = "0x2FBCDA0", Offset = "0x2FBC1A0", Length = "0xC8")]
	[Token(Token = "0x60000BE")]
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	[Address(RVA = "0x2FBCAA0", Offset = "0x2FBBEA0", Length = "0xAA")]
	[NativeMethod("SetLookAtWeight")]
	[Token(Token = "0x60000C1")]
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[Address(RVA = "0x2FBCA30", Offset = "0x2FBBE30", Length = "0x67")]
	[Token(Token = "0x6000198")]
	private static void SetLookAtWeightInternal_Injected(IntPtr _unity_self, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("SetQuaternion is deprecated.")]
	[Token(Token = "0x600016B")]
	public void SetQuaternion(int id, Quaternion value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("SetQuaternion is deprecated.")]
	[Token(Token = "0x600016A")]
	public void SetQuaternion(string name, Quaternion value) { }

	[Address(RVA = "0x2FBCF70", Offset = "0x2FBC370", Length = "0x93")]
	[Token(Token = "0x6000110")]
	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	[Address(RVA = "0x2FBCF20", Offset = "0x2FBC320", Length = "0x50")]
	[Token(Token = "0x60001BD")]
	private static void SetTarget_Injected(IntPtr _unity_self, AvatarTarget targetIndex, float targetNormalizedTime) { }

	[Address(RVA = "0x2FBD300", Offset = "0x2FBC700", Length = "0x8")]
	[Token(Token = "0x6000080")]
	public void SetTrigger(string name) { }

	[Address(RVA = "0x2FBD050", Offset = "0x2FBC450", Length = "0x83")]
	[Token(Token = "0x6000081")]
	public void SetTrigger(int id) { }

	[Address(RVA = "0x2FBD050", Offset = "0x2FBC450", Length = "0x83")]
	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = True)]
	[Token(Token = "0x6000141")]
	private void SetTriggerID(int id) { }

	[Address(RVA = "0x2FBD010", Offset = "0x2FBC410", Length = "0x40")]
	[Token(Token = "0x60001E6")]
	private static void SetTriggerID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x2FBD130", Offset = "0x2FBC530", Length = "0x1C7")]
	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	[Token(Token = "0x6000140")]
	private void SetTriggerString(string name) { }

	[Address(RVA = "0x2FBD0E0", Offset = "0x2FBC4E0", Length = "0x42")]
	[Token(Token = "0x60001E5")]
	private static void SetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("SetVector is deprecated.")]
	[Token(Token = "0x6000167")]
	public void SetVector(int id, Vector3 value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("SetVector is deprecated.")]
	[Token(Token = "0x6000166")]
	public void SetVector(string name, Vector3 value) { }

	[Address(RVA = "0x2FBD350", Offset = "0x2FBC750", Length = "0x76")]
	[Token(Token = "0x600011A")]
	public void StartPlayback() { }

	[Address(RVA = "0x2FBD310", Offset = "0x2FBC710", Length = "0x33")]
	[Token(Token = "0x60001C5")]
	private static void StartPlayback_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBD410", Offset = "0x2FBC810", Length = "0x83")]
	[Token(Token = "0x600011E")]
	public void StartRecording(int frameCount) { }

	[Address(RVA = "0x2FBD3D0", Offset = "0x2FBC7D0", Length = "0x40")]
	[Token(Token = "0x60001C9")]
	private static void StartRecording_Injected(IntPtr _unity_self, int frameCount) { }

	[Address(RVA = "0x2FBD4E0", Offset = "0x2FBC8E0", Length = "0x76")]
	[Token(Token = "0x600011B")]
	public void StopPlayback() { }

	[Address(RVA = "0x2FBD4A0", Offset = "0x2FBC8A0", Length = "0x33")]
	[Token(Token = "0x60001C6")]
	private static void StopPlayback_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBD5A0", Offset = "0x2FBC9A0", Length = "0x76")]
	[Token(Token = "0x600011F")]
	public void StopRecording() { }

	[Address(RVA = "0x2FBD560", Offset = "0x2FBC960", Length = "0x33")]
	[Token(Token = "0x60001CA")]
	private static void StopRecording_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBD660", Offset = "0x2FBCA60", Length = "0x18C")]
	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	[Token(Token = "0x600012C")]
	public static int StringToHash(string name) { }

	[Address(RVA = "0x2FBD620", Offset = "0x2FBCA20", Length = "0x33")]
	[Token(Token = "0x60001D3")]
	private static int StringToHash_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x2FBD840", Offset = "0x2FBCC40", Length = "0x86")]
	[NativeMethod("UpdateWithDelta")]
	[Token(Token = "0x6000150")]
	public void Update(float deltaTime) { }

	[Address(RVA = "0x2FBD7F0", Offset = "0x2FBCBF0", Length = "0x43")]
	[Token(Token = "0x60001F5")]
	private static void Update_Injected(IntPtr _unity_self, float deltaTime) { }

	[Address(RVA = "0x2FBD910", Offset = "0x2FBCD10", Length = "0x76")]
	[NativeConditional("UNITY_EDITOR")]
	[Token(Token = "0x600014F")]
	internal void WriteDefaultPose() { }

	[Address(RVA = "0x2FBD8D0", Offset = "0x2FBCCD0", Length = "0x33")]
	[Token(Token = "0x60001F4")]
	private static void WriteDefaultPose_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FBD9D0", Offset = "0x2FBCDD0", Length = "0x76")]
	[FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = True)]
	[Token(Token = "0x60000FA")]
	public void WriteDefaultValues() { }

	[Address(RVA = "0x2FBD990", Offset = "0x2FBCD90", Length = "0x33")]
	[Token(Token = "0x60001B8")]
	private static void WriteDefaultValues_Injected(IntPtr _unity_self) { }

}

