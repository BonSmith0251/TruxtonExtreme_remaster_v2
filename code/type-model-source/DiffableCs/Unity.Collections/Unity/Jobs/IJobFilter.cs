namespace Unity.Jobs;

[JobProducerType(typeof(JobFilterProducer`1))]
[Token(Token = "0x200000A")]
public interface IJobFilter
{

	[Token(Token = "0x6000011")]
	public bool Execute(int index) { }

}

