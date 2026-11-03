namespace Unity.Jobs;

[Extension]
[Obsolete("'JobParallelIndexListExtensions' has been deprecated; Use 'IJobFilterExtensions' instead.", False)]
[Token(Token = "0x2000008")]
public static class JobParallelIndexListExtensions
{

	[Address(RVA = "0x84DF50", Offset = "0x84D350", Length = "0xF8")]
	[Extension]
	[Obsolete("The signature for 'ScheduleAppend' has changed. 'innerloopBatchCount' is no longer part of this API.", False)]
	[Token(Token = "0x600000E")]
	public static JobHandle ScheduleAppend(T jobData, NativeList<Int32> indices, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x84E050", Offset = "0x84D450", Length = "0xE5")]
	[Extension]
	[Obsolete("The signature for 'ScheduleFilter' has changed. 'innerloopBatchCount' is no longer part of this API.")]
	[Token(Token = "0x600000F")]
	public static JobHandle ScheduleFilter(T jobData, NativeList<Int32> indices, int innerloopBatchCount, JobHandle dependsOn = null) { }

}

