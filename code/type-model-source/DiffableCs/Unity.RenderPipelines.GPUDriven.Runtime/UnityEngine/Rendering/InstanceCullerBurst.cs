namespace UnityEngine.Rendering;

[BurstCompile]
[Token(Token = "0x2000051")]
internal static class InstanceCullerBurst
{
	[Token(Token = "0x2000053")]
	public static class SetupCullingJobInput_0000014D$BurstDirectCall
	{
		[Token(Token = "0x4000173")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2CEFE00", Offset = "0x2CEF200", Length = "0x168")]
		[Token(Token = "0x600016C")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2CEFC80", Offset = "0x2CEF080", Length = "0x175")]
		[BurstDiscard]
		[Token(Token = "0x600016B")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2CEFF70", Offset = "0x2CEF370", Length = "0x385")]
		[Token(Token = "0x600016D")]
		public static void Invoke(float lodBias, float meshLodThreshold, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric, Single* meshLodConstant) { }

	}

	[Token(Token = "0x2000052")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class SetupCullingJobInput_0000014D$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CF0400", Offset = "0x2CEF800", Length = "0xA6")]
		[Token(Token = "0x6000167")]
		public SetupCullingJobInput_0000014D$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2CF0300", Offset = "0x2CEF700", Length = "0xDD")]
		[Token(Token = "0x6000169")]
		public override IAsyncResult BeginInvoke(float lodBias, float meshLodThreshold, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric, Single* meshLodConstant, AsyncCallback unnamed_param_8, object unnamed_param_9) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600016A")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x2CF03E0", Offset = "0x2CEF7E0", Length = "0x14")]
		[Token(Token = "0x6000168")]
		public override void Invoke(float lodBias, float meshLodThreshold, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric, Single* meshLodConstant) { }

	}


	[Address(RVA = "0x2CE3190", Offset = "0x2CE2590", Length = "0xE")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[MonoPInvokeCallback(typeof(SetupCullingJobInput_0000014D$PostfixBurstDelegate))]
	[Token(Token = "0x6000165")]
	public static void SetupCullingJobInput(float lodBias, float meshLodThreshold, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric, Single* meshLodConstant) { }

	[Address(RVA = "0x2CE3000", Offset = "0x2CE2400", Length = "0x18C")]
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x6000166")]
	internal static void SetupCullingJobInput$BurstManaged(float lodBias, float meshLodThreshold, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric, Single* meshLodConstant) { }

}

