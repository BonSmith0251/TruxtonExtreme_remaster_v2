namespace Unity.Jobs;

[JobProducerType(typeof(JobParallelForDeferProducer`1))]
[Token(Token = "0x2000013")]
public interface IJobParallelForDefer
{

	[Token(Token = "0x6000039")]
	public void Execute(int index) { }

}

