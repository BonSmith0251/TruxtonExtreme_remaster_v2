namespace System.Threading.Tasks;

[Token(Token = "0x200028E")]
internal enum CausalityRelation : int
{
	AssignDelegate = 0,
	Join = 1,
	Choice = 2,
	Cancel = 3,
	Error = 4,
}

