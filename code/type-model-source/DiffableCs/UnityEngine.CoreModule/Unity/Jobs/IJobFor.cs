namespace Unity.Jobs;

[JobProducerType(typeof(ForJobStruct`1))]
[Token(Token = "0x2000010")]
public interface IJobFor
{

	[Token(Token = "0x6000016")]
	public void Execute(int index) { }

}

