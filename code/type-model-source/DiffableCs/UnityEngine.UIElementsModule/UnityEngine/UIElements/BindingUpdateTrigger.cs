namespace UnityEngine.UIElements;

[Token(Token = "0x200001F")]
public enum BindingUpdateTrigger : int
{
	WhenDirty = 0,
	OnSourceChanged = 1,
	EveryUpdate = 2,
}

