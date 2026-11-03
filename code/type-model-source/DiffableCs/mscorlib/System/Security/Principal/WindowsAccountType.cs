namespace System.Security.Principal;

[ComVisible(True)]
[Token(Token = "0x200033C")]
public enum WindowsAccountType : int
{
	Normal = 0,
	Guest = 1,
	System = 2,
	Anonymous = 3,
}

