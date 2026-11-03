namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002B2")]
public class HR
{
	[Token(Token = "0x400072D")]
	public const int S_OK = 0; //Field offset: 0x0
	[Token(Token = "0x400072E")]
	public const int E_NOTIMPL = -2147467263; //Field offset: 0x0
	[Token(Token = "0x400072F")]
	public const int E_NOINTERFACE = -2147467262; //Field offset: 0x0
	[Token(Token = "0x4000730")]
	public const int E_POINTER = -2147467261; //Field offset: 0x0
	[Token(Token = "0x4000731")]
	public const int E_ABORT = -2147467260; //Field offset: 0x0
	[Token(Token = "0x4000732")]
	public const int E_ACCESSDENIED = -2147024891; //Field offset: 0x0
	[Token(Token = "0x4000733")]
	public const int E_OUTOFMEMORY = -2147024882; //Field offset: 0x0
	[Token(Token = "0x4000734")]
	public const int E_INVALIDARG = -2147024809; //Field offset: 0x0
	[Token(Token = "0x4000735")]
	public const int E_PENDING = -2147483638; //Field offset: 0x0
	[Token(Token = "0x4000736")]
	public const int E_UNEXPECTED = -2147418113; //Field offset: 0x0
	[Token(Token = "0x4000737")]
	public const int E_NOT_SUPPORTED = -2147024846; //Field offset: 0x0
	[Token(Token = "0x4000738")]
	public const int E_TIME_CRITICAL_THREAD = -2147024480; //Field offset: 0x0
	[Token(Token = "0x4000739")]
	public const int E_NO_TASK_QUEUE = -2147024469; //Field offset: 0x0
	[Token(Token = "0x400073A")]
	public const int E_NOT_SUFFICIENT_BUFFER = -2147024774; //Field offset: 0x0
	[Token(Token = "0x400073B")]
	public const int E_BOUNDS = -2147483637; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000E11")]
	public HR() { }

	[Address(RVA = "0x2B8EBE0", Offset = "0x2B8DFE0", Length = "0x7")]
	[Token(Token = "0x6000E10")]
	public static bool FAILED(int hr) { }

	[Address(RVA = "0x28AC4E0", Offset = "0x28AB8E0", Length = "0xA")]
	[Token(Token = "0x6000E0F")]
	public static bool SUCCEEDED(int hr) { }

}

