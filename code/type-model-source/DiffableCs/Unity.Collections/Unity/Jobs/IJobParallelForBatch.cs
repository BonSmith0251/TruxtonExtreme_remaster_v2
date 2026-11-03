namespace Unity.Jobs;

[JobProducerType(typeof(JobParallelForBatchProducer`1))]
[Token(Token = "0x200000F")]
public interface IJobParallelForBatch
{

	[Token(Token = "0x6000025")]
	public void Execute(int startIndex, int count) { }

}

