namespace UnityEngine.InputSystem.UI;

[Token(Token = "0x2000122")]
internal struct PointerModel
{
	[Token(Token = "0x2000123")]
	internal struct ButtonState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006C0")]
		private bool m_IsPressed; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40006C1")]
		private FramePressState m_FramePressState; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006C2")]
		private float m_PressTime; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006C3")]
		private RaycastResult m_PressRaycast; //Field offset: 0x10
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40006C4")]
		private GameObject m_PressObject; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40006C5")]
		private GameObject m_RawPressObject; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40006C6")]
		private GameObject m_LastPressObject; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40006C7")]
		private GameObject m_DragObject; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40006C8")]
		private Vector2 m_PressPosition; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40006C9")]
		private float m_ClickTime; //Field offset: 0xA8
		[FieldOffset(Offset = "0xAC")]
		[Token(Token = "0x40006CA")]
		private int m_ClickCount; //Field offset: 0xAC
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40006CB")]
		private bool m_Dragging; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB1")]
		[Token(Token = "0x40006CC")]
		private bool m_ClickedOnSameGameObject; //Field offset: 0xB1
		[FieldOffset(Offset = "0xB2")]
		[Token(Token = "0x40006CD")]
		private bool m_IgnoreNextClick; //Field offset: 0xB2

		[Token(Token = "0x170003B0")]
		public bool clickedOnSameGameObject
		{
			[Address(RVA = "0x1D605B0", Offset = "0x1D5F9B0", Length = "0x8")]
			[Token(Token = "0x6000DF3")]
			 get { } //Length: 8
			[Address(RVA = "0x1D604B0", Offset = "0x1D5F8B0", Length = "0x7")]
			[Token(Token = "0x6000DF4")]
			 set { } //Length: 7
		}

		[Token(Token = "0x170003AE")]
		public bool ignoreNextClick
		{
			[Address(RVA = "0x29D5210", Offset = "0x29D4610", Length = "0x8")]
			[Token(Token = "0x6000DEF")]
			 get { } //Length: 8
			[Address(RVA = "0x1D604C0", Offset = "0x1D5F8C0", Length = "0x7")]
			[Token(Token = "0x6000DF0")]
			 set { } //Length: 7
		}

		[Token(Token = "0x170003AD")]
		public bool isPressed
		{
			[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
			[Token(Token = "0x6000DED")]
			 get { } //Length: 4
			[Address(RVA = "0x29D5260", Offset = "0x29D4660", Length = "0x44")]
			[Token(Token = "0x6000DEE")]
			 set { } //Length: 68
		}

		[Token(Token = "0x170003AF")]
		public float pressTime
		{
			[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
			[Token(Token = "0x6000DF1")]
			 get { } //Length: 229
			[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
			[Token(Token = "0x6000DF2")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170003B1")]
		public bool wasPressedThisFrame
		{
			[Address(RVA = "0x29D5220", Offset = "0x29D4620", Length = "0x11")]
			[Token(Token = "0x6000DF5")]
			 get { } //Length: 17
		}

		[Token(Token = "0x170003B2")]
		public bool wasReleasedThisFrame
		{
			[Address(RVA = "0x29D5240", Offset = "0x29D4640", Length = "0x11")]
			[Token(Token = "0x6000DF6")]
			 get { } //Length: 17
		}

		[Address(RVA = "0x29D4FA0", Offset = "0x29D43A0", Length = "0x128")]
		[Token(Token = "0x6000DF8")]
		public void CopyPressStateFrom(PointerEventData eventData) { }

		[Address(RVA = "0x29D50D0", Offset = "0x29D44D0", Length = "0x12B")]
		[Token(Token = "0x6000DF7")]
		public void CopyPressStateTo(PointerEventData eventData) { }

		[Address(RVA = "0x1D605B0", Offset = "0x1D5F9B0", Length = "0x8")]
		[Token(Token = "0x6000DF3")]
		public bool get_clickedOnSameGameObject() { }

		[Address(RVA = "0x29D5210", Offset = "0x29D4610", Length = "0x8")]
		[Token(Token = "0x6000DEF")]
		public bool get_ignoreNextClick() { }

		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[Token(Token = "0x6000DED")]
		public bool get_isPressed() { }

		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x6000DF1")]
		public float get_pressTime() { }

		[Address(RVA = "0x29D5220", Offset = "0x29D4620", Length = "0x11")]
		[Token(Token = "0x6000DF5")]
		public bool get_wasPressedThisFrame() { }

		[Address(RVA = "0x29D5240", Offset = "0x29D4640", Length = "0x11")]
		[Token(Token = "0x6000DF6")]
		public bool get_wasReleasedThisFrame() { }

		[Address(RVA = "0x29D5200", Offset = "0x29D4600", Length = "0x8")]
		[Token(Token = "0x6000DF9")]
		public void OnEndFrame() { }

		[Address(RVA = "0x1D604B0", Offset = "0x1D5F8B0", Length = "0x7")]
		[Token(Token = "0x6000DF4")]
		public void set_clickedOnSameGameObject(bool value) { }

		[Address(RVA = "0x1D604C0", Offset = "0x1D5F8C0", Length = "0x7")]
		[Token(Token = "0x6000DF0")]
		public void set_ignoreNextClick(bool value) { }

		[Address(RVA = "0x29D5260", Offset = "0x29D4660", Length = "0x44")]
		[Token(Token = "0x6000DEE")]
		public void set_isPressed(bool value) { }

		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[Token(Token = "0x6000DF2")]
		public void set_pressTime(float value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006B2")]
	public bool changedThisFrame; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006B3")]
	public ButtonState leftButton; //Field offset: 0x8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40006B4")]
	public ButtonState rightButton; //Field offset: 0xC0
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40006B5")]
	public ButtonState middleButton; //Field offset: 0x178
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x40006B6")]
	public ExtendedPointerEventData eventData; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x40006B7")]
	private Vector2 m_ScreenPosition; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x40006B8")]
	private Vector2 m_ScrollDelta; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x40006B9")]
	private Vector3 m_WorldPosition; //Field offset: 0x248
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x40006BA")]
	private Quaternion m_WorldOrientation; //Field offset: 0x254
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x40006BB")]
	private float m_Pressure; //Field offset: 0x264
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40006BC")]
	private float m_AzimuthAngle; //Field offset: 0x268
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x40006BD")]
	private float m_AltitudeAngle; //Field offset: 0x26C
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40006BE")]
	private float m_Twist; //Field offset: 0x270
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x40006BF")]
	private Vector2 m_Radius; //Field offset: 0x274

	[Token(Token = "0x170003AA")]
	public float altitudeAngle
	{
		[Address(RVA = "0x29E4AF0", Offset = "0x29E3EF0", Length = "0x9")]
		[Token(Token = "0x6000DE4")]
		 get { } //Length: 9
		[Address(RVA = "0x29E4BF0", Offset = "0x29E3FF0", Length = "0x1B")]
		[Token(Token = "0x6000DE5")]
		 set { } //Length: 27
	}

	[Token(Token = "0x170003A9")]
	public float azimuthAngle
	{
		[Address(RVA = "0x29E4B00", Offset = "0x29E3F00", Length = "0x9")]
		[Token(Token = "0x6000DE2")]
		 get { } //Length: 9
		[Address(RVA = "0x29E4C10", Offset = "0x29E4010", Length = "0x1B")]
		[Token(Token = "0x6000DE3")]
		 set { } //Length: 27
	}

	[Token(Token = "0x170003A3")]
	public UIPointerType pointerType
	{
		[Address(RVA = "0x29E4B10", Offset = "0x29E3F10", Length = "0x20")]
		[Token(Token = "0x6000DD7")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170003A8")]
	public float pressure
	{
		[Address(RVA = "0x29E4B40", Offset = "0x29E3F40", Length = "0x9")]
		[Token(Token = "0x6000DE0")]
		 get { } //Length: 9
		[Address(RVA = "0x29E4C30", Offset = "0x29E4030", Length = "0x1B")]
		[Token(Token = "0x6000DE1")]
		 set { } //Length: 27
	}

	[Token(Token = "0x170003AC")]
	public Vector2 radius
	{
		[Address(RVA = "0x29E4B50", Offset = "0x29E3F50", Length = "0x19")]
		[Token(Token = "0x6000DE8")]
		 get { } //Length: 25
		[Address(RVA = "0x29E4C50", Offset = "0x29E4050", Length = "0x50")]
		[Token(Token = "0x6000DE9")]
		 set { } //Length: 80
	}

	[Token(Token = "0x170003A4")]
	public Vector2 screenPosition
	{
		[Address(RVA = "0x29E4B70", Offset = "0x29E3F70", Length = "0x19")]
		[Token(Token = "0x6000DD8")]
		 get { } //Length: 25
		[Address(RVA = "0x29E4CA0", Offset = "0x29E40A0", Length = "0x50")]
		[Token(Token = "0x6000DD9")]
		 set { } //Length: 80
	}

	[Token(Token = "0x170003A7")]
	public Vector2 scrollDelta
	{
		[Address(RVA = "0x29E4B90", Offset = "0x29E3F90", Length = "0x19")]
		[Token(Token = "0x6000DDE")]
		 get { } //Length: 25
		[Address(RVA = "0x29E4CF0", Offset = "0x29E40F0", Length = "0x50")]
		[Token(Token = "0x6000DDF")]
		 set { } //Length: 80
	}

	[Token(Token = "0x170003AB")]
	public float twist
	{
		[Address(RVA = "0x29E4BB0", Offset = "0x29E3FB0", Length = "0x9")]
		[Token(Token = "0x6000DE6")]
		 get { } //Length: 9
		[Address(RVA = "0x29E4D40", Offset = "0x29E4140", Length = "0x1B")]
		[Token(Token = "0x6000DE7")]
		 set { } //Length: 27
	}

	[Token(Token = "0x170003A6")]
	public Quaternion worldOrientation
	{
		[Address(RVA = "0x29E4BC0", Offset = "0x29E3FC0", Length = "0xE")]
		[Token(Token = "0x6000DDC")]
		 get { } //Length: 14
		[Address(RVA = "0x29E4D60", Offset = "0x29E4160", Length = "0x6B")]
		[Token(Token = "0x6000DDD")]
		 set { } //Length: 107
	}

	[Token(Token = "0x170003A5")]
	public Vector3 worldPosition
	{
		[Address(RVA = "0x29E4BD0", Offset = "0x29E3FD0", Length = "0x19")]
		[Token(Token = "0x6000DDA")]
		 get { } //Length: 25
		[Address(RVA = "0x29E4DD0", Offset = "0x29E41D0", Length = "0x7B")]
		[Token(Token = "0x6000DDB")]
		 set { } //Length: 123
	}

	[Address(RVA = "0x29E4A30", Offset = "0x29E3E30", Length = "0xB5")]
	[Token(Token = "0x6000DEA")]
	public PointerModel(ExtendedPointerEventData eventData) { }

	[Address(RVA = "0x29E48B0", Offset = "0x29E3CB0", Length = "0xFA")]
	[Token(Token = "0x6000DEC")]
	public void CopyTouchOrPenStateFrom(PointerEventData eventData) { }

	[Address(RVA = "0x29E4AF0", Offset = "0x29E3EF0", Length = "0x9")]
	[Token(Token = "0x6000DE4")]
	public float get_altitudeAngle() { }

	[Address(RVA = "0x29E4B00", Offset = "0x29E3F00", Length = "0x9")]
	[Token(Token = "0x6000DE2")]
	public float get_azimuthAngle() { }

	[Address(RVA = "0x29E4B10", Offset = "0x29E3F10", Length = "0x20")]
	[Token(Token = "0x6000DD7")]
	public UIPointerType get_pointerType() { }

	[Address(RVA = "0x29E4B40", Offset = "0x29E3F40", Length = "0x9")]
	[Token(Token = "0x6000DE0")]
	public float get_pressure() { }

	[Address(RVA = "0x29E4B50", Offset = "0x29E3F50", Length = "0x19")]
	[Token(Token = "0x6000DE8")]
	public Vector2 get_radius() { }

	[Address(RVA = "0x29E4B70", Offset = "0x29E3F70", Length = "0x19")]
	[Token(Token = "0x6000DD8")]
	public Vector2 get_screenPosition() { }

	[Address(RVA = "0x29E4B90", Offset = "0x29E3F90", Length = "0x19")]
	[Token(Token = "0x6000DDE")]
	public Vector2 get_scrollDelta() { }

	[Address(RVA = "0x29E4BB0", Offset = "0x29E3FB0", Length = "0x9")]
	[Token(Token = "0x6000DE6")]
	public float get_twist() { }

	[Address(RVA = "0x29E4BC0", Offset = "0x29E3FC0", Length = "0xE")]
	[Token(Token = "0x6000DDC")]
	public Quaternion get_worldOrientation() { }

	[Address(RVA = "0x29E4BD0", Offset = "0x29E3FD0", Length = "0x19")]
	[Token(Token = "0x6000DDA")]
	public Vector3 get_worldPosition() { }

	[Address(RVA = "0x29E49B0", Offset = "0x29E3DB0", Length = "0x79")]
	[Token(Token = "0x6000DEB")]
	public void OnFrameFinished() { }

	[Address(RVA = "0x29E4BF0", Offset = "0x29E3FF0", Length = "0x1B")]
	[Token(Token = "0x6000DE5")]
	public void set_altitudeAngle(float value) { }

	[Address(RVA = "0x29E4C10", Offset = "0x29E4010", Length = "0x1B")]
	[Token(Token = "0x6000DE3")]
	public void set_azimuthAngle(float value) { }

	[Address(RVA = "0x29E4C30", Offset = "0x29E4030", Length = "0x1B")]
	[Token(Token = "0x6000DE1")]
	public void set_pressure(float value) { }

	[Address(RVA = "0x29E4C50", Offset = "0x29E4050", Length = "0x50")]
	[Token(Token = "0x6000DE9")]
	public void set_radius(Vector2 value) { }

	[Address(RVA = "0x29E4CA0", Offset = "0x29E40A0", Length = "0x50")]
	[Token(Token = "0x6000DD9")]
	public void set_screenPosition(Vector2 value) { }

	[Address(RVA = "0x29E4CF0", Offset = "0x29E40F0", Length = "0x50")]
	[Token(Token = "0x6000DDF")]
	public void set_scrollDelta(Vector2 value) { }

	[Address(RVA = "0x29E4D40", Offset = "0x29E4140", Length = "0x1B")]
	[Token(Token = "0x6000DE7")]
	public void set_twist(float value) { }

	[Address(RVA = "0x29E4D60", Offset = "0x29E4160", Length = "0x6B")]
	[Token(Token = "0x6000DDD")]
	public void set_worldOrientation(Quaternion value) { }

	[Address(RVA = "0x29E4DD0", Offset = "0x29E41D0", Length = "0x7B")]
	[Token(Token = "0x6000DDB")]
	public void set_worldPosition(Vector3 value) { }

}

