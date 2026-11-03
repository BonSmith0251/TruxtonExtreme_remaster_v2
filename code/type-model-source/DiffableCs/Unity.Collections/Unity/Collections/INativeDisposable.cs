namespace Unity.Collections;

[Token(Token = "0x200003C")]
public interface INativeDisposable : IDisposable
{

	[Token(Token = "0x600013A")]
	public JobHandle Dispose(JobHandle inputDeps) { }

}

