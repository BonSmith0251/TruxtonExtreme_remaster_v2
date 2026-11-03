namespace System.Threading.Tasks;

[FriendAccessAllowed]
[Token(Token = "0x200028D")]
internal enum AsyncCausalityStatus : int
{
	Started = 0,
	Completed = 1,
	Canceled = 2,
	Error = 3,
}

