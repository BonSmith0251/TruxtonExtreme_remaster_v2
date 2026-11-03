namespace UnityEngine.UIElements.UIR;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererJobProcessor.h")]
[Token(Token = "0x200056D")]
internal static class JobProcessor
{

	[Address(RVA = "0x32DDBF0", Offset = "0x32DCFF0", Length = "0x5A")]
	[Token(Token = "0x6002782")]
	internal static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount) { }

	[Address(RVA = "0x32DDBA0", Offset = "0x32DCFA0", Length = "0x50")]
	[Token(Token = "0x6002785")]
	private static void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	[Address(RVA = "0x32DDCA0", Offset = "0x32DD0A0", Length = "0x5A")]
	[Token(Token = "0x6002783")]
	internal static JobHandle ScheduleCopyMeshJobs(IntPtr buffer, int jobCount) { }

	[Address(RVA = "0x32DDC50", Offset = "0x32DD050", Length = "0x50")]
	[Token(Token = "0x6002786")]
	private static void ScheduleCopyMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	[Address(RVA = "0x32DDD50", Offset = "0x32DD150", Length = "0x5A")]
	[Token(Token = "0x6002781")]
	internal static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount) { }

	[Address(RVA = "0x32DDD00", Offset = "0x32DD100", Length = "0x50")]
	[Token(Token = "0x6002784")]
	private static void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

}

