namespace System.Threading.Tasks;

[Token(Token = "0x200028F")]
internal enum CausalitySynchronousWork : int
{
	CompletionNotification = 0,
	ProgressNotification = 1,
	Execution = 2,
}

