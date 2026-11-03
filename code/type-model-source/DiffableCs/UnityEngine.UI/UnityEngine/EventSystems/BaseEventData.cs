namespace UnityEngine.EventSystems;

[Token(Token = "0x200009C")]
public class BaseEventData : AbstractEventData
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002D1")]
	private readonly EventSystem m_EventSystem; //Field offset: 0x18

	[Token(Token = "0x1700019F")]
	public BaseInputModule currentInputModule
	{
		[Address(RVA = "0x21B1A00", Offset = "0x21B0E00", Length = "0x1B")]
		[Token(Token = "0x6000636")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170001A0")]
	public GameObject selectedObject
	{
		[Address(RVA = "0x21B19B0", Offset = "0x21B0DB0", Length = "0x1B")]
		[Token(Token = "0x6000637")]
		 get { } //Length: 27
		[Address(RVA = "0x3461350", Offset = "0x3460750", Length = "0x24")]
		[Token(Token = "0x6000638")]
		 set { } //Length: 36
	}

	[Address(RVA = "0x1F079E0", Offset = "0x1F06DE0", Length = "0x31")]
	[Token(Token = "0x6000635")]
	public BaseEventData(EventSystem eventSystem) { }

	[Address(RVA = "0x21B1A00", Offset = "0x21B0E00", Length = "0x1B")]
	[Token(Token = "0x6000636")]
	public BaseInputModule get_currentInputModule() { }

	[Address(RVA = "0x21B19B0", Offset = "0x21B0DB0", Length = "0x1B")]
	[Token(Token = "0x6000637")]
	public GameObject get_selectedObject() { }

	[Address(RVA = "0x3461350", Offset = "0x3460750", Length = "0x24")]
	[Token(Token = "0x6000638")]
	public void set_selectedObject(GameObject value) { }

}

