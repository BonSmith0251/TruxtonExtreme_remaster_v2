namespace Unity.Jobs;

[JobProducerType(typeof(JobStruct`1))]
[Token(Token = "0x200000C")]
public interface IJob
{

	[Token(Token = "0x600000D")]
	public void Execute() { }

}

