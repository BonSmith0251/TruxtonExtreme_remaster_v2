namespace UnityEngine.LowLevelPhysics2D;

[NativeHeader("Modules/Physics2D/LowLevel/PhysicsLowLevel2D.h")]
[NativeHeader("Modules/Physics2D/LowLevel/PhysicsWorldManager2D.h")]
[StaticAccessor("PhysicsLowLevel2D", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200001A")]
internal static class PhysicsLowLevelScripting2D
{
	[Token(Token = "0x200001B")]
	public struct PhysicsBuffer : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005B")]
		private IntPtr m_Buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400005C")]
		private int m_Size; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400005D")]
		private Allocator m_Allocator; //Field offset: 0xC

		[Token(Token = "0x17000034")]
		public bool IsEmpty
		{
			[Address(RVA = "0xF1EA30", Offset = "0xF1DE30", Length = "0x8")]
			[IsReadOnly]
			[Token(Token = "0x600010E")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x3128C50", Offset = "0x3128050", Length = "0x32")]
		[Token(Token = "0x600010D")]
		public override void Dispose() { }

		[Address(RVA = "0xF1EA30", Offset = "0xF1DE30", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x600010E")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0x9F2C00", Offset = "0x9F2000", Length = "0x6F")]
		[IsReadOnly]
		[Token(Token = "0x600010A")]
		public NativeArray<T> ToNativeArray() { }

		[Address(RVA = "0x9F2CD0", Offset = "0x9F20D0", Length = "0xDB")]
		[IsReadOnly]
		[Token(Token = "0x600010C")]
		public ReadOnlySpan<T> ToReadOnlySpan() { }

		[Address(RVA = "0x9F2DB0", Offset = "0x9F21B0", Length = "0xEE")]
		[IsReadOnly]
		[Token(Token = "0x600010B")]
		public Span<T> ToSpan() { }

		[Address(RVA = "0x3128C90", Offset = "0x3128090", Length = "0x88")]
		[IsReadOnly]
		[Token(Token = "0x600010F")]
		public virtual string ToString() { }

	}


	[Address(RVA = "0x3129D30", Offset = "0x3129130", Length = "0x6A")]
	[NativeMethod(Name = "PhysicsDistanceJoint::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000C9")]
	internal static PhysicsDistanceJointDefinition DistanceJoint_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x3129CE0", Offset = "0x31290E0", Length = "0x43")]
	[Token(Token = "0x60000EF")]
	private static void DistanceJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsDistanceJointDefinition ret) { }

	[Address(RVA = "0x3129DF0", Offset = "0x31291F0", Length = "0x62")]
	[NativeMethod(Name = "PhysicsFixedJoint::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000CD")]
	internal static PhysicsFixedJointDefinition FixedJoint_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x3129DA0", Offset = "0x31291A0", Length = "0x43")]
	[Token(Token = "0x60000F3")]
	private static void FixedJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsFixedJointDefinition ret) { }

	[Address(RVA = "0x3129EB0", Offset = "0x31292B0", Length = "0x64")]
	[NativeMethod(Name = "PhysicsHingeJoint::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000CC")]
	internal static PhysicsHingeJointDefinition HingeJoint_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x3129E60", Offset = "0x3129260", Length = "0x43")]
	[Token(Token = "0x60000F2")]
	private static void HingeJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsHingeJointDefinition ret) { }

	[Address(RVA = "0x3129F60", Offset = "0x3129360", Length = "0x33")]
	[NativeMethod(Name = "PhysicsAABB::IsValid", IsThreadSafe = True)]
	[Token(Token = "0x60000D3")]
	internal static bool PhysicsAABB_IsValid(PhysicsAABB aabb) { }

	[Address(RVA = "0x3129F20", Offset = "0x3129320", Length = "0x33")]
	[Token(Token = "0x60000F9")]
	private static bool PhysicsAABB_IsValid_Injected(in PhysicsAABB aabb) { }

	[Address(RVA = "0x3129FE0", Offset = "0x31293E0", Length = "0x34")]
	[NativeMethod(Name = "PhysicsBody::GetBodyType", IsThreadSafe = True)]
	[Token(Token = "0x60000C3")]
	internal static BodyType PhysicsBody_GetBodyType(PhysicsBody body) { }

	[Address(RVA = "0x3129FA0", Offset = "0x31293A0", Length = "0x33")]
	[Token(Token = "0x60000E9")]
	private static BodyType PhysicsBody_GetBodyType_Injected(in PhysicsBody body) { }

	[Address(RVA = "0x312A060", Offset = "0x3129460", Length = "0x34")]
	[NativeMethod(Name = "PhysicsBody::GetCallbackTarget", IsThreadSafe = True)]
	[Token(Token = "0x60000C4")]
	internal static object PhysicsBody_GetCallbackTarget(PhysicsBody body) { }

	[Address(RVA = "0x312A020", Offset = "0x3129420", Length = "0x33")]
	[Token(Token = "0x60000EA")]
	private static object PhysicsBody_GetCallbackTarget_Injected(in PhysicsBody body) { }

	[Address(RVA = "0x312A0F0", Offset = "0x31294F0", Length = "0x58")]
	[NativeMethod(Name = "PhysicsBody::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000C1")]
	internal static PhysicsBodyDefinition PhysicsBody_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x312A0A0", Offset = "0x31294A0", Length = "0x43")]
	[Token(Token = "0x60000E7")]
	private static void PhysicsBody_GetDefaultDefinition_Injected(bool useSettings, out PhysicsBodyDefinition ret) { }

	[Address(RVA = "0x312A190", Offset = "0x3129590", Length = "0x34")]
	[NativeMethod(Name = "PhysicsBody::IsValid", IsThreadSafe = True)]
	[Token(Token = "0x60000C2")]
	internal static bool PhysicsBody_IsValid(PhysicsBody body) { }

	[Address(RVA = "0x312A150", Offset = "0x3129550", Length = "0x33")]
	[Token(Token = "0x60000E8")]
	private static bool PhysicsBody_IsValid_Injected(in PhysicsBody body) { }

	[Address(RVA = "0x312A220", Offset = "0x3129620", Length = "0x58")]
	[NativeMethod(Name = "PhysicsChain::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000C5")]
	internal static PhysicsChainDefinition PhysicsChain_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x312A1D0", Offset = "0x31295D0", Length = "0x43")]
	[Token(Token = "0x60000EB")]
	private static void PhysicsChain_GetDefaultDefinition_Injected(bool useSettings, out PhysicsChainDefinition ret) { }

	[Address(RVA = "0x312A2C0", Offset = "0x31296C0", Length = "0x33")]
	[NativeMethod(Name = "PhysicsLowLevel2D::PhysicsContactId::IsValid", IsThreadSafe = True)]
	[Token(Token = "0x60000DD")]
	internal static bool PhysicsContactId_IsValid(ContactId contactId) { }

	[Address(RVA = "0x312A280", Offset = "0x3129680", Length = "0x33")]
	[Token(Token = "0x6000100")]
	private static bool PhysicsContactId_IsValid_Injected(in ContactId contactId) { }

	[Address(RVA = "0x312A300", Offset = "0x3129700", Length = "0x2A")]
	[NativeMethod(Name = "PhysicsLowLevel2D::GetBypassLowLevel")]
	[StaticAccessor("GetPhysicsLowLevel2D()", StaticAccessorType::Arrow (1))]
	[Token(Token = "0x60000D5")]
	internal static bool PhysicsGlobal_GetBypassLowLevel() { }

	[Address(RVA = "0x312A330", Offset = "0x3129730", Length = "0x2A")]
	[NativeMethod(Name = "PhysicsLowLevel2D::IsRenderingAllowed")]
	[StaticAccessor("GetPhysicsLowLevel2D()", StaticAccessorType::Arrow (1))]
	[Token(Token = "0x60000D6")]
	internal static bool PhysicsGlobal_IsRenderingAllowed() { }

	[Address(RVA = "0x312A3C0", Offset = "0x31297C0", Length = "0xAB")]
	[NativeMethod(Name = "PhysicsWorldManager2D::PopulateWorldTransformWrite")]
	[StaticAccessor("GetPhysicsLowLevel2D()->GetWorldManager2D()", StaticAccessorType::Arrow (1))]
	[Token(Token = "0x60000D7")]
	internal static int PhysicsGlobal_PopulateWorldTransformWrite(PhysicsWorld world, IntPtr transformAccessArrayIntPtr, Span<TransformWriteTween> transformWriteTweensArray) { }

	[Address(RVA = "0x312A360", Offset = "0x3129760", Length = "0x52")]
	[Token(Token = "0x60000FA")]
	private static int PhysicsGlobal_PopulateWorldTransformWrite_Injected(in PhysicsWorld world, IntPtr transformAccessArrayIntPtr, ref ManagedSpanWrapper transformWriteTweensArray) { }

	[Address(RVA = "0x312A4B0", Offset = "0x31298B0", Length = "0x34")]
	[NativeMethod(Name = "PhysicsJoint::GetCallbackTarget", IsThreadSafe = True)]
	[Token(Token = "0x60000C8")]
	internal static object PhysicsJoint_GetCallbackTarget(PhysicsJoint joint) { }

	[Address(RVA = "0x312A470", Offset = "0x3129870", Length = "0x33")]
	[Token(Token = "0x60000EE")]
	private static object PhysicsJoint_GetCallbackTarget_Injected(in PhysicsJoint joint) { }

	[Address(RVA = "0x312A530", Offset = "0x3129930", Length = "0x34")]
	[NativeMethod(Name = "PhysicsJoint::GetJointType", IsThreadSafe = True)]
	[Token(Token = "0x60000C7")]
	internal static JointType PhysicsJoint_GetJointType(PhysicsJoint joint) { }

	[Address(RVA = "0x312A4F0", Offset = "0x31298F0", Length = "0x33")]
	[Token(Token = "0x60000ED")]
	private static JointType PhysicsJoint_GetJointType_Injected(in PhysicsJoint joint) { }

	[Address(RVA = "0x312A5B0", Offset = "0x31299B0", Length = "0x34")]
	[NativeMethod(Name = "PhysicsJoint::IsValid", IsThreadSafe = True)]
	[Token(Token = "0x60000C6")]
	internal static bool PhysicsJoint_IsValid(PhysicsJoint joint) { }

	[Address(RVA = "0x312A570", Offset = "0x3129970", Length = "0x33")]
	[Token(Token = "0x60000EC")]
	private static bool PhysicsJoint_IsValid_Injected(in PhysicsJoint joint) { }

	[Address(RVA = "0x312A5F0", Offset = "0x31299F0", Length = "0x4A")]
	[NativeMethod(Name = "PhysicsMath::Atan2", IsThreadSafe = True)]
	[Token(Token = "0x60000D4")]
	internal static float PhysicsMath_Atan2(float y, float x) { }

	[Address(RVA = "0x312A690", Offset = "0x3129A90", Length = "0x4B")]
	[NativeMethod(Name = "PhysicsRotate::Create", IsThreadSafe = True)]
	[Token(Token = "0x60000D0")]
	internal static PhysicsRotate PhysicsRotate_CreateAngle(float angle) { }

	[Address(RVA = "0x312A640", Offset = "0x3129A40", Length = "0x43")]
	[Token(Token = "0x60000F6")]
	private static void PhysicsRotate_CreateAngle_Injected(float angle, out PhysicsRotate ret) { }

	[Address(RVA = "0x312A730", Offset = "0x3129B30", Length = "0x44")]
	[NativeMethod(Name = "PhysicsRotate::Create", IsThreadSafe = True)]
	[Token(Token = "0x60000CF")]
	internal static PhysicsRotate PhysicsRotate_CreateDirection(in Vector2 direction) { }

	[Address(RVA = "0x312A6E0", Offset = "0x3129AE0", Length = "0x42")]
	[Token(Token = "0x60000F5")]
	private static void PhysicsRotate_CreateDirection_Injected(in Vector2 direction, out PhysicsRotate ret) { }

	[Address(RVA = "0x312A7C0", Offset = "0x3129BC0", Length = "0x34")]
	[NativeMethod(Name = "PhysicsRotate::GetAngle", IsThreadSafe = True)]
	[Token(Token = "0x60000D2")]
	internal static float PhysicsRotate_GetAngle(PhysicsRotate rotate) { }

	[Address(RVA = "0x312A780", Offset = "0x3129B80", Length = "0x33")]
	[Token(Token = "0x60000F8")]
	private static float PhysicsRotate_GetAngle_Injected(in PhysicsRotate rotate) { }

	[Address(RVA = "0x312A840", Offset = "0x3129C40", Length = "0x34")]
	[NativeMethod(Name = "PhysicsRotate::IsValid", IsThreadSafe = True)]
	[Token(Token = "0x60000D1")]
	internal static bool PhysicsRotate_IsValid(PhysicsRotate rotation) { }

	[Address(RVA = "0x312A800", Offset = "0x3129C00", Length = "0x33")]
	[Token(Token = "0x60000F7")]
	private static bool PhysicsRotate_IsValid_Injected(in PhysicsRotate rotation) { }

	[Address(RVA = "0x312A8C0", Offset = "0x3129CC0", Length = "0x34")]
	[NativeMethod(Name = "PhysicsShape::GetCallbackTarget", IsThreadSafe = True)]
	[Token(Token = "0x60000DC")]
	internal static object PhysicsShape_GetCallbackTarget(PhysicsShape shape) { }

	[Address(RVA = "0x312A880", Offset = "0x3129C80", Length = "0x33")]
	[Token(Token = "0x60000FF")]
	private static object PhysicsShape_GetCallbackTarget_Injected(in PhysicsShape shape) { }

	[Address(RVA = "0x312A950", Offset = "0x3129D50", Length = "0x5C")]
	[NativeMethod(Name = "PhysicsShape::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000D8")]
	internal static PhysicsShapeDefinition PhysicsShape_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x312A900", Offset = "0x3129D00", Length = "0x43")]
	[Token(Token = "0x60000FB")]
	private static void PhysicsShape_GetDefaultDefinition_Injected(bool useSettings, out PhysicsShapeDefinition ret) { }

	[Address(RVA = "0x312A9F0", Offset = "0x3129DF0", Length = "0x40")]
	[NativeMethod(Name = "PhysicsShape::GetDefaultSurfaceMaterial", IsThreadSafe = True)]
	[Token(Token = "0x60000D9")]
	internal static SurfaceMaterial PhysicsShape_GetDefaultSurfaceMaterial() { }

	[Address(RVA = "0x312A9B0", Offset = "0x3129DB0", Length = "0x33")]
	[Token(Token = "0x60000FC")]
	private static void PhysicsShape_GetDefaultSurfaceMaterial_Injected(out SurfaceMaterial ret) { }

	[Address(RVA = "0x312AA70", Offset = "0x3129E70", Length = "0x34")]
	[NativeMethod(Name = "PhysicsShape::GetShapeType", IsThreadSafe = True)]
	[Token(Token = "0x60000DB")]
	internal static ShapeType PhysicsShape_GetShapeType(PhysicsShape shape) { }

	[Address(RVA = "0x312AA30", Offset = "0x3129E30", Length = "0x33")]
	[Token(Token = "0x60000FE")]
	private static ShapeType PhysicsShape_GetShapeType_Injected(in PhysicsShape shape) { }

	[Address(RVA = "0x312AAF0", Offset = "0x3129EF0", Length = "0x34")]
	[NativeMethod(Name = "PhysicsShape::IsValid", IsThreadSafe = True)]
	[Token(Token = "0x60000DA")]
	internal static bool PhysicsShape_IsValid(PhysicsShape shape) { }

	[Address(RVA = "0x312AAB0", Offset = "0x3129EB0", Length = "0x33")]
	[Token(Token = "0x60000FD")]
	private static bool PhysicsShape_IsValid_Injected(in PhysicsShape shape) { }

	[Address(RVA = "0x312AB70", Offset = "0x3129F70", Length = "0x33")]
	[NativeMethod(Name = "PhysicsWorld::DrawAllWorlds")]
	[Token(Token = "0x60000E6")]
	internal static void PhysicsWorld_DrawAllWorlds(PhysicsAABB drawAABB) { }

	[Address(RVA = "0x312AB30", Offset = "0x3129F30", Length = "0x33")]
	[Token(Token = "0x6000109")]
	private static void PhysicsWorld_DrawAllWorlds_Injected(in PhysicsAABB drawAABB) { }

	[Address(RVA = "0x312AC00", Offset = "0x312A000", Length = "0x53")]
	[NativeMethod(Name = "PhysicsWorld::GetBodyUpdateCallbackTargets", IsThreadSafe = True)]
	[Token(Token = "0x60000E1")]
	internal static BodyUpdateCallbackTargets PhysicsWorld_GetBodyUpdateCallbackTargets(PhysicsWorld world, Allocator allocator) { }

	[Address(RVA = "0x312ABB0", Offset = "0x3129FB0", Length = "0x50")]
	[Token(Token = "0x6000104")]
	private static void PhysicsWorld_GetBodyUpdateCallbackTargets_Injected(in PhysicsWorld world, Allocator allocator, out BodyUpdateCallbackTargets ret) { }

	[Address(RVA = "0x312ACB0", Offset = "0x312A0B0", Length = "0x57")]
	[NativeMethod(Name = "PhysicsWorld::GetContactCallbackTargets", IsThreadSafe = True)]
	[Token(Token = "0x60000E3")]
	internal static ContactCallbackTargets PhysicsWorld_GetContactCallbackTargets(PhysicsWorld world, Allocator allocator) { }

	[Address(RVA = "0x312AC60", Offset = "0x312A060", Length = "0x50")]
	[Token(Token = "0x6000106")]
	private static void PhysicsWorld_GetContactCallbackTargets_Injected(in PhysicsWorld world, Allocator allocator, out ContactCallbackTargets ret) { }

	[Address(RVA = "0x312AD60", Offset = "0x312A160", Length = "0x53")]
	[NativeMethod(Name = "PhysicsWorld::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000DE")]
	internal static PhysicsWorldDefinition PhysicsWorld_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x312AD10", Offset = "0x312A110", Length = "0x43")]
	[Token(Token = "0x6000101")]
	private static void PhysicsWorld_GetDefaultDefinition_Injected(bool useSettings, out PhysicsWorldDefinition ret) { }

	[Address(RVA = "0x312AE10", Offset = "0x312A210", Length = "0x53")]
	[NativeMethod(Name = "PhysicsWorld::GetJointThresholdCallbackTargets", IsThreadSafe = True)]
	[Token(Token = "0x60000E4")]
	internal static JointThresholdCallbackTargets PhysicsWorld_GetJointThresholdCallbackTargets(PhysicsWorld world, Allocator allocator) { }

	[Address(RVA = "0x312ADC0", Offset = "0x312A1C0", Length = "0x50")]
	[Token(Token = "0x6000107")]
	private static void PhysicsWorld_GetJointThresholdCallbackTargets_Injected(in PhysicsWorld world, Allocator allocator, out JointThresholdCallbackTargets ret) { }

	[Address(RVA = "0x312AEC0", Offset = "0x312A2C0", Length = "0x2ED")]
	[NativeMethod(Name = "PhysicsWorld::GetRenderMaterial", IsThreadSafe = True)]
	[Token(Token = "0x60000E5")]
	internal static Material PhysicsWorld_GetRenderMaterial(string editorResourceName, string playerResourceName) { }

	[Address(RVA = "0x312AE70", Offset = "0x312A270", Length = "0x42")]
	[Token(Token = "0x6000108")]
	private static IntPtr PhysicsWorld_GetRenderMaterial_Injected(ref ManagedSpanWrapper editorResourceName, ref ManagedSpanWrapper playerResourceName) { }

	[Address(RVA = "0x312B200", Offset = "0x312A600", Length = "0x57")]
	[NativeMethod(Name = "PhysicsWorld::GetTriggerCallbackTargets", IsThreadSafe = True)]
	[Token(Token = "0x60000E2")]
	internal static TriggerCallbackTargets PhysicsWorld_GetTriggerCallbackTargets(PhysicsWorld world, Allocator allocator) { }

	[Address(RVA = "0x312B1B0", Offset = "0x312A5B0", Length = "0x50")]
	[Token(Token = "0x6000105")]
	private static void PhysicsWorld_GetTriggerCallbackTargets_Injected(in PhysicsWorld world, Allocator allocator, out TriggerCallbackTargets ret) { }

	[Address(RVA = "0x312B2A0", Offset = "0x312A6A0", Length = "0x33")]
	[NativeMethod(Name = "PhysicsWorld::IsValid", IsThreadSafe = True)]
	[Token(Token = "0x60000DF")]
	internal static bool PhysicsWorld_IsValid(PhysicsWorld world) { }

	[Address(RVA = "0x312B260", Offset = "0x312A660", Length = "0x33")]
	[Token(Token = "0x6000102")]
	private static bool PhysicsWorld_IsValid_Injected(in PhysicsWorld world) { }

	[Address(RVA = "0x312B330", Offset = "0x312A730", Length = "0x9B")]
	[NativeMethod(Name = "PhysicsWorld::SetTransformWriteTweens", IsThreadSafe = True)]
	[Token(Token = "0x60000E0")]
	internal static void PhysicsWorld_SetTransformWriteTweens(PhysicsWorld world, ReadOnlySpan<TransformWriteTween> transformWriteTweens) { }

	[Address(RVA = "0x312B2E0", Offset = "0x312A6E0", Length = "0x42")]
	[Token(Token = "0x6000103")]
	private static void PhysicsWorld_SetTransformWriteTweens_Injected(in PhysicsWorld world, ref ManagedSpanWrapper transformWriteTweens) { }

	[Address(RVA = "0x312B420", Offset = "0x312A820", Length = "0x69")]
	[NativeMethod(Name = "PhysicsRelativeJoint::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000CA")]
	internal static PhysicsRelativeJointDefinition RelativeJoint_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x312B3D0", Offset = "0x312A7D0", Length = "0x43")]
	[Token(Token = "0x60000F0")]
	private static void RelativeJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsRelativeJointDefinition ret) { }

	[Address(RVA = "0x312B4E0", Offset = "0x312A8E0", Length = "0x64")]
	[NativeMethod(Name = "PhysicsSliderJoint::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000CB")]
	internal static PhysicsSliderJointDefinition SliderJoint_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x312B490", Offset = "0x312A890", Length = "0x43")]
	[Token(Token = "0x60000F1")]
	private static void SliderJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsSliderJointDefinition ret) { }

	[Address(RVA = "0x312B5A0", Offset = "0x312A9A0", Length = "0x69")]
	[NativeMethod(Name = "PhysicsWheelJoint::GetDefaultDefinition", IsThreadSafe = True)]
	[Token(Token = "0x60000CE")]
	internal static PhysicsWheelJointDefinition WheelJoint_GetDefaultDefinition(bool useSettings) { }

	[Address(RVA = "0x312B550", Offset = "0x312A950", Length = "0x43")]
	[Token(Token = "0x60000F4")]
	private static void WheelJoint_GetDefaultDefinition_Injected(bool useSettings, out PhysicsWheelJointDefinition ret) { }

}

