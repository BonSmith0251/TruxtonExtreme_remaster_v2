namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000161")]
public interface IValueField
{

	[Token(Token = "0x170001D8")]
	public T value
	{
		[Token(Token = "0x6000AB7")]
		 get { } //Length: 0
		[Token(Token = "0x6000AB8")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000AB9")]
	public void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue) { }

	[Token(Token = "0x6000AB7")]
	public T get_value() { }

	[Token(Token = "0x6000AB8")]
	public void set_value(T value) { }

	[Token(Token = "0x6000ABA")]
	public void StartDragging() { }

	[Token(Token = "0x6000ABB")]
	public void StopDragging() { }

}

