namespace JetBrains.Annotations;

[Flags]
[Token(Token = "0x2000083")]
public enum CollectionAccessType : int
{
	None = 0,
	Read = 1,
	ModifyExistingContent = 2,
	UpdatedContent = 6,
}

