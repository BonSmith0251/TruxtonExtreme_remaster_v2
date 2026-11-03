namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
[NativeHeader("Modules/Animation/Constraints/AimConstraint.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x200002C")]
[UsedByNativeCode]
public sealed class AimConstraint : Behaviour, IConstraint, IConstraintInternal
{
	[Token(Token = "0x200002D")]
	internal enum WorldUpType : int
	{
		SceneUp = 0,
		ObjectUp = 1,
		ObjectRotationUp = 2,
		Vector = 3,
		None = 4,
	}


	[Token(Token = "0x17000058")]
	public Vector3 aimVector
	{
		[Address(RVA = "0x2FABEF0", Offset = "0x2FAB2F0", Length = "0x90")]
		[Token(Token = "0x6000233")]
		 get { } //Length: 144
		[Address(RVA = "0x2FAC840", Offset = "0x2FABC40", Length = "0x85")]
		[Token(Token = "0x6000234")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000053")]
	public override bool constraintActive
	{
		[Address(RVA = "0x2FABFD0", Offset = "0x2FAB3D0", Length = "0x76")]
		[Token(Token = "0x6000229")]
		 get { } //Length: 118
		[Address(RVA = "0x2FAC920", Offset = "0x2FABD20", Length = "0x86")]
		[Token(Token = "0x600022A")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000054")]
	public override bool locked
	{
		[Address(RVA = "0x2FAC090", Offset = "0x2FAB490", Length = "0x76")]
		[Token(Token = "0x600022B")]
		 get { } //Length: 118
		[Address(RVA = "0x2FACA00", Offset = "0x2FABE00", Length = "0x86")]
		[Token(Token = "0x600022C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000055")]
	public Vector3 rotationAtRest
	{
		[Address(RVA = "0x2FAC160", Offset = "0x2FAB560", Length = "0x90")]
		[Token(Token = "0x600022D")]
		 get { } //Length: 144
		[Address(RVA = "0x2FACAE0", Offset = "0x2FABEE0", Length = "0x85")]
		[Token(Token = "0x600022E")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000057")]
	public Axis rotationAxis
	{
		[Address(RVA = "0x2FAC240", Offset = "0x2FAB640", Length = "0x76")]
		[Token(Token = "0x6000231")]
		 get { } //Length: 118
		[Address(RVA = "0x2FACBB0", Offset = "0x2FABFB0", Length = "0x83")]
		[Token(Token = "0x6000232")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000056")]
	public Vector3 rotationOffset
	{
		[Address(RVA = "0x2FAC310", Offset = "0x2FAB710", Length = "0x90")]
		[Token(Token = "0x600022F")]
		 get { } //Length: 144
		[Address(RVA = "0x2FACC90", Offset = "0x2FAC090", Length = "0x85")]
		[Token(Token = "0x6000230")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700005D")]
	public override int sourceCount
	{
		[Address(RVA = "0x2FAB3B0", Offset = "0x2FAA7B0", Length = "0x9B")]
		[Token(Token = "0x600023D")]
		 get { } //Length: 155
	}

	[Token(Token = "0x17000059")]
	public Vector3 upVector
	{
		[Address(RVA = "0x2FAC400", Offset = "0x2FAB800", Length = "0x90")]
		[Token(Token = "0x6000235")]
		 get { } //Length: 144
		[Address(RVA = "0x2FACD70", Offset = "0x2FAC170", Length = "0x85")]
		[Token(Token = "0x6000236")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000052")]
	public override float weight
	{
		[Address(RVA = "0x2FAC4E0", Offset = "0x2FAB8E0", Length = "0x76")]
		[Token(Token = "0x6000227")]
		 get { } //Length: 118
		[Address(RVA = "0x2FACE50", Offset = "0x2FAC250", Length = "0x86")]
		[Token(Token = "0x6000228")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700005B")]
	public Transform worldUpObject
	{
		[Address(RVA = "0x2FAC5A0", Offset = "0x2FAB9A0", Length = "0x90")]
		[Token(Token = "0x6000239")]
		 get { } //Length: 144
		[Address(RVA = "0x2FACF30", Offset = "0x2FAC330", Length = "0xBA")]
		[Token(Token = "0x600023A")]
		 set { } //Length: 186
	}

	[Token(Token = "0x1700005C")]
	public WorldUpType worldUpType
	{
		[Address(RVA = "0x2FAC680", Offset = "0x2FABA80", Length = "0x76")]
		[Token(Token = "0x600023B")]
		 get { } //Length: 118
		[Address(RVA = "0x2FAD030", Offset = "0x2FAC430", Length = "0x83")]
		[Token(Token = "0x600023C")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700005A")]
	public Vector3 worldUpVector
	{
		[Address(RVA = "0x2FAC750", Offset = "0x2FABB50", Length = "0x90")]
		[Token(Token = "0x6000237")]
		 get { } //Length: 144
		[Address(RVA = "0x2FAD110", Offset = "0x2FAC510", Length = "0x85")]
		[Token(Token = "0x6000238")]
		 set { } //Length: 133
	}

	[Address(RVA = "0x2FABE60", Offset = "0x2FAB260", Length = "0x3A")]
	[Token(Token = "0x6000225")]
	private AimConstraint() { }

	[Address(RVA = "0x2FAB2E0", Offset = "0x2FAA6E0", Length = "0x85")]
	[Token(Token = "0x6000242")]
	public override int AddSource(ConstraintSource source) { }

	[Address(RVA = "0x2FAB290", Offset = "0x2FAA690", Length = "0x42")]
	[Token(Token = "0x6000263")]
	private static int AddSource_Injected(IntPtr _unity_self, in ConstraintSource source) { }

	[Address(RVA = "0x2FABEF0", Offset = "0x2FAB2F0", Length = "0x90")]
	[Token(Token = "0x6000233")]
	public Vector3 get_aimVector() { }

	[Address(RVA = "0x2FABEA0", Offset = "0x2FAB2A0", Length = "0x42")]
	[Token(Token = "0x6000256")]
	private static void get_aimVector_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FABFD0", Offset = "0x2FAB3D0", Length = "0x76")]
	[Token(Token = "0x6000229")]
	public override bool get_constraintActive() { }

	[Address(RVA = "0x2FABF90", Offset = "0x2FAB390", Length = "0x33")]
	[Token(Token = "0x600024C")]
	private static bool get_constraintActive_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAC090", Offset = "0x2FAB490", Length = "0x76")]
	[Token(Token = "0x600022B")]
	public override bool get_locked() { }

	[Address(RVA = "0x2FAC050", Offset = "0x2FAB450", Length = "0x33")]
	[Token(Token = "0x600024E")]
	private static bool get_locked_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAC160", Offset = "0x2FAB560", Length = "0x90")]
	[Token(Token = "0x600022D")]
	public Vector3 get_rotationAtRest() { }

	[Address(RVA = "0x2FAC110", Offset = "0x2FAB510", Length = "0x42")]
	[Token(Token = "0x6000250")]
	private static void get_rotationAtRest_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FAC240", Offset = "0x2FAB640", Length = "0x76")]
	[Token(Token = "0x6000231")]
	public Axis get_rotationAxis() { }

	[Address(RVA = "0x2FAC200", Offset = "0x2FAB600", Length = "0x33")]
	[Token(Token = "0x6000254")]
	private static Axis get_rotationAxis_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAC310", Offset = "0x2FAB710", Length = "0x90")]
	[Token(Token = "0x600022F")]
	public Vector3 get_rotationOffset() { }

	[Address(RVA = "0x2FAC2C0", Offset = "0x2FAB6C0", Length = "0x42")]
	[Token(Token = "0x6000252")]
	private static void get_rotationOffset_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FAB3B0", Offset = "0x2FAA7B0", Length = "0x9B")]
	[Token(Token = "0x600023D")]
	public override int get_sourceCount() { }

	[Address(RVA = "0x2FAC400", Offset = "0x2FAB800", Length = "0x90")]
	[Token(Token = "0x6000235")]
	public Vector3 get_upVector() { }

	[Address(RVA = "0x2FAC3B0", Offset = "0x2FAB7B0", Length = "0x42")]
	[Token(Token = "0x6000258")]
	private static void get_upVector_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FAC4E0", Offset = "0x2FAB8E0", Length = "0x76")]
	[Token(Token = "0x6000227")]
	public override float get_weight() { }

	[Address(RVA = "0x2FAC4A0", Offset = "0x2FAB8A0", Length = "0x33")]
	[Token(Token = "0x600024A")]
	private static float get_weight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAC5A0", Offset = "0x2FAB9A0", Length = "0x90")]
	[Token(Token = "0x6000239")]
	public Transform get_worldUpObject() { }

	[Address(RVA = "0x2FAC560", Offset = "0x2FAB960", Length = "0x33")]
	[Token(Token = "0x600025C")]
	private static IntPtr get_worldUpObject_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAC680", Offset = "0x2FABA80", Length = "0x76")]
	[Token(Token = "0x600023B")]
	public WorldUpType get_worldUpType() { }

	[Address(RVA = "0x2FAC640", Offset = "0x2FABA40", Length = "0x33")]
	[Token(Token = "0x600025E")]
	private static WorldUpType get_worldUpType_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FAC750", Offset = "0x2FABB50", Length = "0x90")]
	[Token(Token = "0x6000237")]
	public Vector3 get_worldUpVector() { }

	[Address(RVA = "0x2FAC700", Offset = "0x2FABB00", Length = "0x42")]
	[Token(Token = "0x600025A")]
	private static void get_worldUpVector_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x2FAB540", Offset = "0x2FAA940", Length = "0xBC")]
	[Token(Token = "0x6000245")]
	public override ConstraintSource GetSource(int index) { }

	[Address(RVA = "0x2FAB3B0", Offset = "0x2FAA7B0", Length = "0x9B")]
	[FreeFunction("ConstraintBindings::GetSourceCount")]
	[Token(Token = "0x600023E")]
	private static int GetSourceCountInternal(AimConstraint self) { }

	[Address(RVA = "0x2FAB370", Offset = "0x2FAA770", Length = "0x33")]
	[Token(Token = "0x6000260")]
	private static int GetSourceCountInternal_Injected(IntPtr self) { }

	[Address(RVA = "0x2FAB4A0", Offset = "0x2FAA8A0", Length = "0x9D")]
	[NativeName("GetSource")]
	[Token(Token = "0x6000246")]
	private ConstraintSource GetSourceInternal(int index) { }

	[Address(RVA = "0x2FAB450", Offset = "0x2FAA850", Length = "0x50")]
	[Token(Token = "0x6000265")]
	private static void GetSourceInternal_Injected(IntPtr _unity_self, int index, out ConstraintSource ret) { }

	[Address(RVA = "0x2FAB650", Offset = "0x2FAAA50", Length = "0xA7")]
	[FreeFunction(Name = "ConstraintBindings::GetSources", HasExplicitThis = True)]
	[Token(Token = "0x600023F")]
	public override void GetSources(List<ConstraintSource> sources) { }

	[Address(RVA = "0x2FAB600", Offset = "0x2FAAA00", Length = "0x42")]
	[Token(Token = "0x6000261")]
	private static void GetSources_Injected(IntPtr _unity_self, List<ConstraintSource> sources) { }

	[Address(RVA = "0x2FAB700", Offset = "0x2FAAB00", Length = "0x33")]
	[Token(Token = "0x6000226")]
	private static void Internal_Create(AimConstraint self) { }

	[Address(RVA = "0x2FAB810", Offset = "0x2FAAC10", Length = "0x8B")]
	[Token(Token = "0x6000243")]
	public override void RemoveSource(int index) { }

	[Address(RVA = "0x2FAB780", Offset = "0x2FAAB80", Length = "0x83")]
	[NativeName("RemoveSource")]
	[Token(Token = "0x6000244")]
	private void RemoveSourceInternal(int index) { }

	[Address(RVA = "0x2FAB740", Offset = "0x2FAAB40", Length = "0x40")]
	[Token(Token = "0x6000264")]
	private static void RemoveSourceInternal_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x2FAC840", Offset = "0x2FABC40", Length = "0x85")]
	[Token(Token = "0x6000234")]
	public void set_aimVector(Vector3 value) { }

	[Address(RVA = "0x2FAC7F0", Offset = "0x2FABBF0", Length = "0x42")]
	[Token(Token = "0x6000257")]
	private static void set_aimVector_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FAC920", Offset = "0x2FABD20", Length = "0x86")]
	[Token(Token = "0x600022A")]
	public override void set_constraintActive(bool value) { }

	[Address(RVA = "0x2FAC8D0", Offset = "0x2FABCD0", Length = "0x42")]
	[Token(Token = "0x600024D")]
	private static void set_constraintActive_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FACA00", Offset = "0x2FABE00", Length = "0x86")]
	[Token(Token = "0x600022C")]
	public override void set_locked(bool value) { }

	[Address(RVA = "0x2FAC9B0", Offset = "0x2FABDB0", Length = "0x42")]
	[Token(Token = "0x600024F")]
	private static void set_locked_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x2FACAE0", Offset = "0x2FABEE0", Length = "0x85")]
	[Token(Token = "0x600022E")]
	public void set_rotationAtRest(Vector3 value) { }

	[Address(RVA = "0x2FACA90", Offset = "0x2FABE90", Length = "0x42")]
	[Token(Token = "0x6000251")]
	private static void set_rotationAtRest_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FACBB0", Offset = "0x2FABFB0", Length = "0x83")]
	[Token(Token = "0x6000232")]
	public void set_rotationAxis(Axis value) { }

	[Address(RVA = "0x2FACB70", Offset = "0x2FABF70", Length = "0x40")]
	[Token(Token = "0x6000255")]
	private static void set_rotationAxis_Injected(IntPtr _unity_self, Axis value) { }

	[Address(RVA = "0x2FACC90", Offset = "0x2FAC090", Length = "0x85")]
	[Token(Token = "0x6000230")]
	public void set_rotationOffset(Vector3 value) { }

	[Address(RVA = "0x2FACC40", Offset = "0x2FAC040", Length = "0x42")]
	[Token(Token = "0x6000253")]
	private static void set_rotationOffset_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FACD70", Offset = "0x2FAC170", Length = "0x85")]
	[Token(Token = "0x6000236")]
	public void set_upVector(Vector3 value) { }

	[Address(RVA = "0x2FACD20", Offset = "0x2FAC120", Length = "0x42")]
	[Token(Token = "0x6000259")]
	private static void set_upVector_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FACE50", Offset = "0x2FAC250", Length = "0x86")]
	[Token(Token = "0x6000228")]
	public override void set_weight(float value) { }

	[Address(RVA = "0x2FACE00", Offset = "0x2FAC200", Length = "0x43")]
	[Token(Token = "0x600024B")]
	private static void set_weight_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x2FACF30", Offset = "0x2FAC330", Length = "0xBA")]
	[Token(Token = "0x600023A")]
	public void set_worldUpObject(Transform value) { }

	[Address(RVA = "0x2FACEE0", Offset = "0x2FAC2E0", Length = "0x42")]
	[Token(Token = "0x600025D")]
	private static void set_worldUpObject_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x2FAD030", Offset = "0x2FAC430", Length = "0x83")]
	[Token(Token = "0x600023C")]
	public void set_worldUpType(WorldUpType value) { }

	[Address(RVA = "0x2FACFF0", Offset = "0x2FAC3F0", Length = "0x40")]
	[Token(Token = "0x600025F")]
	private static void set_worldUpType_Injected(IntPtr _unity_self, WorldUpType value) { }

	[Address(RVA = "0x2FAD110", Offset = "0x2FAC510", Length = "0x85")]
	[Token(Token = "0x6000238")]
	public void set_worldUpVector(Vector3 value) { }

	[Address(RVA = "0x2FAD0C0", Offset = "0x2FAC4C0", Length = "0x42")]
	[Token(Token = "0x600025B")]
	private static void set_worldUpVector_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x2FAB990", Offset = "0x2FAAD90", Length = "0x9B")]
	[Token(Token = "0x6000247")]
	public override void SetSource(int index, ConstraintSource source) { }

	[Address(RVA = "0x2FAB8F0", Offset = "0x2FAACF0", Length = "0x93")]
	[NativeName("SetSource")]
	[Token(Token = "0x6000248")]
	private void SetSourceInternal(int index, ConstraintSource source) { }

	[Address(RVA = "0x2FAB8A0", Offset = "0x2FAACA0", Length = "0x50")]
	[Token(Token = "0x6000266")]
	private static void SetSourceInternal_Injected(IntPtr _unity_self, int index, in ConstraintSource source) { }

	[Address(RVA = "0x2FABB30", Offset = "0x2FAAF30", Length = "0x100")]
	[Token(Token = "0x6000240")]
	public override void SetSources(List<ConstraintSource> sources) { }

	[Address(RVA = "0x2FABA80", Offset = "0x2FAAE80", Length = "0xAA")]
	[FreeFunction("ConstraintBindings::SetSources", ThrowsException = True)]
	[Token(Token = "0x6000241")]
	private static void SetSourcesInternal(AimConstraint self, List<ConstraintSource> sources) { }

	[Address(RVA = "0x2FABA30", Offset = "0x2FAAE30", Length = "0x42")]
	[Token(Token = "0x6000262")]
	private static void SetSourcesInternal_Injected(IntPtr self, List<ConstraintSource> sources) { }

	[Address(RVA = "0x2FABC40", Offset = "0x2FAB040", Length = "0x214")]
	[Token(Token = "0x6000249")]
	private void ValidateSourceIndex(int index) { }

}

