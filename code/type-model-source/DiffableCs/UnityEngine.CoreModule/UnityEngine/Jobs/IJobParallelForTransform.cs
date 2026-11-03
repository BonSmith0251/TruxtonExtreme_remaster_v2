namespace UnityEngine.Jobs;

[JobProducerType(typeof(TransformParallelForLoopStruct`1))]
[Token(Token = "0x2000206")]
public interface IJobParallelForTransform
{

	[Token(Token = "0x6001721")]
	public void Execute(int index, TransformAccess transform) { }

}

