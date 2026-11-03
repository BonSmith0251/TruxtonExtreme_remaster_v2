namespace UnityEngine.EventSystems;

[Token(Token = "0x20000BC")]
public class BaseInput : UIBehaviour
{

	[Token(Token = "0x170001E6")]
	public override Vector2 compositionCursorPos
	{
		[Address(RVA = "0x34628F0", Offset = "0x3461CF0", Length = "0x7")]
		[Token(Token = "0x6000702")]
		 get { } //Length: 7
		[Address(RVA = "0x3462940", Offset = "0x3461D40", Length = "0x11")]
		[Token(Token = "0x6000703")]
		 set { } //Length: 17
	}

	[Token(Token = "0x170001E4")]
	public override string compositionString
	{
		[Address(RVA = "0x310E590", Offset = "0x310D990", Length = "0x7")]
		[Token(Token = "0x60006FF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001E5")]
	public override IMECompositionMode imeCompositionMode
	{
		[Address(RVA = "0x3462900", Offset = "0x3461D00", Length = "0x7")]
		[Token(Token = "0x6000700")]
		 get { } //Length: 7
		[Address(RVA = "0x3462960", Offset = "0x3461D60", Length = "0x9")]
		[Token(Token = "0x6000701")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001E8")]
	public override Vector2 mousePosition
	{
		[Address(RVA = "0x3462910", Offset = "0x3461D10", Length = "0x28")]
		[Token(Token = "0x6000708")]
		 get { } //Length: 40
	}

	[Token(Token = "0x170001E7")]
	public override bool mousePresent
	{
		[Address(RVA = "0x310E5D0", Offset = "0x310D9D0", Length = "0x7")]
		[Token(Token = "0x6000704")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001E9")]
	public override Vector2 mouseScrollDelta
	{
		[Address(RVA = "0x310E5E0", Offset = "0x310D9E0", Length = "0x7")]
		[Token(Token = "0x6000709")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001EA")]
	public override float mouseScrollDeltaPerTick
	{
		[Address(RVA = "0x21D6EB0", Offset = "0x21D62B0", Length = "0x9")]
		[Token(Token = "0x600070A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170001EC")]
	public override int touchCount
	{
		[Address(RVA = "0x310E5F0", Offset = "0x310D9F0", Length = "0x7")]
		[Token(Token = "0x600070C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001EB")]
	public override bool touchSupported
	{
		[Address(RVA = "0x310E600", Offset = "0x310DA00", Length = "0x7")]
		[Token(Token = "0x600070B")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000710")]
	public BaseInput() { }

	[Address(RVA = "0x34628F0", Offset = "0x3461CF0", Length = "0x7")]
	[Token(Token = "0x6000702")]
	public override Vector2 get_compositionCursorPos() { }

	[Address(RVA = "0x310E590", Offset = "0x310D990", Length = "0x7")]
	[Token(Token = "0x60006FF")]
	public override string get_compositionString() { }

	[Address(RVA = "0x3462900", Offset = "0x3461D00", Length = "0x7")]
	[Token(Token = "0x6000700")]
	public override IMECompositionMode get_imeCompositionMode() { }

	[Address(RVA = "0x3462910", Offset = "0x3461D10", Length = "0x28")]
	[Token(Token = "0x6000708")]
	public override Vector2 get_mousePosition() { }

	[Address(RVA = "0x310E5D0", Offset = "0x310D9D0", Length = "0x7")]
	[Token(Token = "0x6000704")]
	public override bool get_mousePresent() { }

	[Address(RVA = "0x310E5E0", Offset = "0x310D9E0", Length = "0x7")]
	[Token(Token = "0x6000709")]
	public override Vector2 get_mouseScrollDelta() { }

	[Address(RVA = "0x21D6EB0", Offset = "0x21D62B0", Length = "0x9")]
	[Token(Token = "0x600070A")]
	public override float get_mouseScrollDeltaPerTick() { }

	[Address(RVA = "0x310E5F0", Offset = "0x310D9F0", Length = "0x7")]
	[Token(Token = "0x600070C")]
	public override int get_touchCount() { }

	[Address(RVA = "0x310E600", Offset = "0x310DA00", Length = "0x7")]
	[Token(Token = "0x600070B")]
	public override bool get_touchSupported() { }

	[Address(RVA = "0x310E4A0", Offset = "0x310D8A0", Length = "0xA")]
	[Token(Token = "0x600070E")]
	public override float GetAxisRaw(string axisName) { }

	[Address(RVA = "0x310E4B0", Offset = "0x310D8B0", Length = "0xA")]
	[Token(Token = "0x600070F")]
	public override bool GetButtonDown(string buttonName) { }

	[Address(RVA = "0x310E530", Offset = "0x310D930", Length = "0x9")]
	[Token(Token = "0x6000707")]
	public override bool GetMouseButton(int button) { }

	[Address(RVA = "0x310E510", Offset = "0x310D910", Length = "0x9")]
	[Token(Token = "0x6000705")]
	public override bool GetMouseButtonDown(int button) { }

	[Address(RVA = "0x310E520", Offset = "0x310D920", Length = "0x9")]
	[Token(Token = "0x6000706")]
	public override bool GetMouseButtonUp(int button) { }

	[Address(RVA = "0x310E540", Offset = "0x310D940", Length = "0x46")]
	[Token(Token = "0x600070D")]
	public override Touch GetTouch(int index) { }

	[Address(RVA = "0x3462940", Offset = "0x3461D40", Length = "0x11")]
	[Token(Token = "0x6000703")]
	public override void set_compositionCursorPos(Vector2 value) { }

	[Address(RVA = "0x3462960", Offset = "0x3461D60", Length = "0x9")]
	[Token(Token = "0x6000701")]
	public override void set_imeCompositionMode(IMECompositionMode value) { }

}

