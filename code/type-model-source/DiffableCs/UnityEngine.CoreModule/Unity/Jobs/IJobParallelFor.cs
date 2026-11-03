namespace Unity.Jobs;

[JobProducerType(typeof(ParallelForJobStruct`1))]
[Token(Token = "0x2000014")]
public interface IJobParallelFor
{

	[Token(Token = "0x6000020")]
	public void Execute(int index) { }

}

