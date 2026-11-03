namespace UnityEngine.UIElements;

[Token(Token = "0x2000223")]
public interface IPointerEvent
{

	[Token(Token = "0x170002B3")]
	public bool actionKey
	{
		[Token(Token = "0x6000EE7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A7")]
	public float altitudeAngle
	{
		[Token(Token = "0x6000EDB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002B2")]
	public bool altKey
	{
		[Token(Token = "0x6000EE6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A8")]
	public float azimuthAngle
	{
		[Token(Token = "0x6000EDC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029E")]
	public int button
	{
		[Token(Token = "0x6000ED2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A4")]
	public int clickCount
	{
		[Token(Token = "0x6000ED8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002B1")]
	public bool commandKey
	{
		[Token(Token = "0x6000EE5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002B0")]
	public bool ctrlKey
	{
		[Token(Token = "0x6000EE4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A2")]
	public Vector3 deltaPosition
	{
		[Token(Token = "0x6000ED6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A3")]
	public float deltaTime
	{
		[Token(Token = "0x6000ED7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029D")]
	public bool isPrimary
	{
		[Token(Token = "0x6000ED1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A1")]
	public Vector3 localPosition
	{
		[Token(Token = "0x6000ED5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002AE")]
	public EventModifiers modifiers
	{
		[Token(Token = "0x6000EE2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002AB")]
	public PenStatus penStatus
	{
		[Token(Token = "0x6000EDF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029B")]
	public int pointerId
	{
		[Token(Token = "0x6000ECF")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029C")]
	public string pointerType
	{
		[Token(Token = "0x6000ED0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A0")]
	public Vector3 position
	{
		[Token(Token = "0x6000ED4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029F")]
	public int pressedButtons
	{
		[Token(Token = "0x6000ED3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A5")]
	public float pressure
	{
		[Token(Token = "0x6000ED9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002AC")]
	public Vector2 radius
	{
		[Token(Token = "0x6000EE0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002AD")]
	public Vector2 radiusVariance
	{
		[Token(Token = "0x6000EE1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002AF")]
	public bool shiftKey
	{
		[Token(Token = "0x6000EE3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A6")]
	public float tangentialPressure
	{
		[Token(Token = "0x6000EDA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002AA")]
	public Vector2 tilt
	{
		[Token(Token = "0x6000EDE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A9")]
	public float twist
	{
		[Token(Token = "0x6000EDD")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000EE7")]
	public bool get_actionKey() { }

	[Token(Token = "0x6000EDB")]
	public float get_altitudeAngle() { }

	[Token(Token = "0x6000EE6")]
	public bool get_altKey() { }

	[Token(Token = "0x6000EDC")]
	public float get_azimuthAngle() { }

	[Token(Token = "0x6000ED2")]
	public int get_button() { }

	[Token(Token = "0x6000ED8")]
	public int get_clickCount() { }

	[Token(Token = "0x6000EE5")]
	public bool get_commandKey() { }

	[Token(Token = "0x6000EE4")]
	public bool get_ctrlKey() { }

	[Token(Token = "0x6000ED6")]
	public Vector3 get_deltaPosition() { }

	[Token(Token = "0x6000ED7")]
	public float get_deltaTime() { }

	[Token(Token = "0x6000ED1")]
	public bool get_isPrimary() { }

	[Token(Token = "0x6000ED5")]
	public Vector3 get_localPosition() { }

	[Token(Token = "0x6000EE2")]
	public EventModifiers get_modifiers() { }

	[Token(Token = "0x6000EDF")]
	public PenStatus get_penStatus() { }

	[Token(Token = "0x6000ECF")]
	public int get_pointerId() { }

	[Token(Token = "0x6000ED0")]
	public string get_pointerType() { }

	[Token(Token = "0x6000ED4")]
	public Vector3 get_position() { }

	[Token(Token = "0x6000ED3")]
	public int get_pressedButtons() { }

	[Token(Token = "0x6000ED9")]
	public float get_pressure() { }

	[Token(Token = "0x6000EE0")]
	public Vector2 get_radius() { }

	[Token(Token = "0x6000EE1")]
	public Vector2 get_radiusVariance() { }

	[Token(Token = "0x6000EE3")]
	public bool get_shiftKey() { }

	[Token(Token = "0x6000EDA")]
	public float get_tangentialPressure() { }

	[Token(Token = "0x6000EDE")]
	public Vector2 get_tilt() { }

	[Token(Token = "0x6000EDD")]
	public float get_twist() { }

}

