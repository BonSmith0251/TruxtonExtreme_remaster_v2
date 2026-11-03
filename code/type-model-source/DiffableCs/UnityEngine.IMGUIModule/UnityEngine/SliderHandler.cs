namespace UnityEngine;

[Token(Token = "0x200002C")]
internal struct SliderHandler
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000104")]
	private readonly Rect position; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000105")]
	private readonly float currentValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000106")]
	private readonly float size; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000107")]
	private readonly float start; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000108")]
	private readonly float end; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000109")]
	private readonly GUIStyle slider; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400010A")]
	private readonly GUIStyle thumb; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400010B")]
	private readonly GUIStyle thumbExtent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400010C")]
	private readonly bool horiz; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400010D")]
	private readonly int id; //Field offset: 0x3C

	[Address(RVA = "0x30F9870", Offset = "0x30F8C70", Length = "0x7D")]
	[Token(Token = "0x60001FD")]
	public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null) { }

	[Address(RVA = "0x30F7120", Offset = "0x30F6520", Length = "0x27")]
	[Token(Token = "0x600020B")]
	private float Clamp(float value) { }

	[Address(RVA = "0x30F7150", Offset = "0x30F6550", Length = "0x2C")]
	[Token(Token = "0x6000213")]
	private float ClampedCurrentValue() { }

	[Address(RVA = "0x30DE1C0", Offset = "0x30DD5C0", Length = "0x37")]
	[Token(Token = "0x6000209")]
	private Event CurrentEvent() { }

	[Address(RVA = "0x30F7180", Offset = "0x30F6580", Length = "0x89")]
	[Token(Token = "0x6000203")]
	private EventType CurrentEventType() { }

	[Address(RVA = "0x30F7210", Offset = "0x30F6610", Length = "0x1B1")]
	[Token(Token = "0x6000204")]
	private int CurrentScrollTroughSide() { }

	[Address(RVA = "0x30F73D0", Offset = "0x30F67D0", Length = "0x8A")]
	[Token(Token = "0x60001FE")]
	public float Handle() { }

	[Address(RVA = "0x30F7460", Offset = "0x30F6860", Length = "0x36F")]
	[Token(Token = "0x6000212")]
	private Rect HorizontalThumbRect() { }

	[Address(RVA = "0x30F77D0", Offset = "0x30F6BD0", Length = "0x13")]
	[Token(Token = "0x6000205")]
	private bool IsEmptySlider() { }

	[Address(RVA = "0x30F77F0", Offset = "0x30F6BF0", Length = "0x12")]
	[Token(Token = "0x6000217")]
	private float MaxValue() { }

	[Address(RVA = "0x30F7810", Offset = "0x30F6C10", Length = "0xD")]
	[Token(Token = "0x6000218")]
	private float MinValue() { }

	[Address(RVA = "0x30F7820", Offset = "0x30F6C20", Length = "0x178")]
	[Token(Token = "0x6000214")]
	private float MousePosition() { }

	[Address(RVA = "0x30F79A0", Offset = "0x30F6DA0", Length = "0x61E")]
	[Token(Token = "0x60001FF")]
	private float OnMouseDown() { }

	[Address(RVA = "0x30F7FC0", Offset = "0x30F73C0", Length = "0x1C4")]
	[Token(Token = "0x6000200")]
	private float OnMouseDrag() { }

	[Address(RVA = "0x30F8190", Offset = "0x30F7590", Length = "0x148")]
	[Token(Token = "0x6000201")]
	private float OnMouseUp() { }

	[Address(RVA = "0x30F82E0", Offset = "0x30F76E0", Length = "0x6CA")]
	[Token(Token = "0x6000202")]
	private float OnRepaint() { }

	[Address(RVA = "0x30F89B0", Offset = "0x30F7DB0", Length = "0xA4")]
	[Token(Token = "0x6000207")]
	private float PageMovementValue() { }

	[Address(RVA = "0x30F8A60", Offset = "0x30F7E60", Length = "0xAE")]
	[Token(Token = "0x6000208")]
	private float PageUpMovementBound() { }

	[Address(RVA = "0x30F8B10", Offset = "0x30F7F10", Length = "0x230")]
	[Token(Token = "0x600020E")]
	private SliderState SliderState() { }

	[Address(RVA = "0x30F8D50", Offset = "0x30F8150", Length = "0x51")]
	[Token(Token = "0x600020D")]
	private void StartDraggingWithValue(float dragStartValue) { }

	[Address(RVA = "0x30F8DB0", Offset = "0x30F81B0", Length = "0x85")]
	[Token(Token = "0x6000206")]
	private bool SupportsPageMovements() { }

	[Address(RVA = "0x30F8E40", Offset = "0x30F8240", Length = "0x1F3")]
	[Token(Token = "0x600020F")]
	private Rect ThumbExtRect() { }

	[Address(RVA = "0x30F9040", Offset = "0x30F8440", Length = "0x45")]
	[Token(Token = "0x6000210")]
	private Rect ThumbRect() { }

	[Address(RVA = "0x30F9040", Offset = "0x30F8440", Length = "0x45")]
	[Token(Token = "0x600020C")]
	private Rect ThumbSelectionRect() { }

	[Address(RVA = "0x30F9090", Offset = "0x30F8490", Length = "0x28D")]
	[Token(Token = "0x6000216")]
	private float ThumbSize() { }

	[Address(RVA = "0x30F9320", Offset = "0x30F8720", Length = "0x10A")]
	[Token(Token = "0x600020A")]
	private float ValueForCurrentMousePosition() { }

	[Address(RVA = "0x30F9430", Offset = "0x30F8830", Length = "0x105")]
	[Token(Token = "0x6000215")]
	private float ValuesPerPixel() { }

	[Address(RVA = "0x30F9540", Offset = "0x30F8940", Length = "0x329")]
	[Token(Token = "0x6000211")]
	private Rect VerticalThumbRect() { }

}

