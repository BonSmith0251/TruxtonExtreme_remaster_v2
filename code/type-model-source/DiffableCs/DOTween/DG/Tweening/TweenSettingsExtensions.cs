namespace DG.Tweening;

[Extension]
[Token(Token = "0x200006B")]
public static class TweenSettingsExtensions
{

	[Address(RVA = "0x65FAB0", Offset = "0x65EEB0", Length = "0xBB")]
	[Extension]
	[Token(Token = "0x6000255")]
	public static Sequence Append(Sequence s, Tween t) { }

	[Address(RVA = "0x65F9C0", Offset = "0x65EDC0", Length = "0x6C")]
	[Extension]
	[Token(Token = "0x600025B")]
	public static Sequence AppendCallback(Sequence s, TweenCallback callback) { }

	[Address(RVA = "0x65FA30", Offset = "0x65EE30", Length = "0x73")]
	[Extension]
	[Token(Token = "0x6000259")]
	public static Sequence AppendInterval(Sequence s, float interval) { }

	[Address(RVA = "0x65FCE0", Offset = "0x65F0E0", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6000265")]
	public static TweenerCore<Vector2, Vector2, CircleOptions> From(TweenerCore<Vector2, Vector2, CircleOptions> t, float fromValueDegrees, bool setImmediately = true, bool isRelative = false) { }

	[Address(RVA = "0x65FC30", Offset = "0x65F030", Length = "0xB0")]
	[Extension]
	[Token(Token = "0x6000264")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> From(TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true, bool isRelative = false) { }

	[Address(RVA = "0x65FB70", Offset = "0x65EF70", Length = "0xB5")]
	[Extension]
	[Token(Token = "0x6000263")]
	public static TweenerCore<Color, Color, ColorOptions> From(TweenerCore<Color, Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true, bool isRelative = false) { }

	[Address(RVA = "0x94ED70", Offset = "0x94E170", Length = "0x13A")]
	[Extension]
	[Token(Token = "0x6000262")]
	public static TweenerCore<T1, T2, TPlugOptions> From(TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true, bool isRelative = false) { }

	[Address(RVA = "0x94EF30", Offset = "0x94E330", Length = "0x70")]
	[Extension]
	[Token(Token = "0x6000261")]
	public static T From(T t, bool setImmediately, bool isRelative) { }

	[Address(RVA = "0x94EEB0", Offset = "0x94E2B0", Length = "0x7A")]
	[Extension]
	[Token(Token = "0x6000260")]
	public static T From(T t, bool isRelative) { }

	[Address(RVA = "0x94EFA0", Offset = "0x94E3A0", Length = "0x60")]
	[Extension]
	[Token(Token = "0x600025F")]
	public static T From(T t) { }

	[Address(RVA = "0x65FE00", Offset = "0x65F200", Length = "0xB8")]
	[Extension]
	[Token(Token = "0x6000258")]
	public static Sequence Insert(Sequence s, float atPosition, Tween t) { }

	[Address(RVA = "0x65FD90", Offset = "0x65F190", Length = "0x6A")]
	[Extension]
	[Token(Token = "0x600025D")]
	public static Sequence InsertCallback(Sequence s, float atPosition, TweenCallback callback) { }

	[Address(RVA = "0x65FEC0", Offset = "0x65F2C0", Length = "0xBB")]
	[Extension]
	[Token(Token = "0x6000257")]
	public static Sequence Join(Sequence s, Tween t) { }

	[Address(RVA = "0x94F000", Offset = "0x94E400", Length = "0x30")]
	[Extension]
	[Token(Token = "0x6000250")]
	public static T OnComplete(T t, TweenCallback action) { }

	[Address(RVA = "0x94F030", Offset = "0x94E430", Length = "0x33")]
	[Extension]
	[Token(Token = "0x6000251")]
	public static T OnKill(T t, TweenCallback action) { }

	[Address(RVA = "0x94F070", Offset = "0x94E470", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x600024C")]
	public static T OnPause(T t, TweenCallback action) { }

	[Address(RVA = "0x94F0A0", Offset = "0x94E4A0", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x600024B")]
	public static T OnPlay(T t, TweenCallback action) { }

	[Address(RVA = "0x94F0D0", Offset = "0x94E4D0", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x600024D")]
	public static T OnRewind(T t, TweenCallback action) { }

	[Address(RVA = "0x94F100", Offset = "0x94E500", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x600024A")]
	public static T OnStart(T t, TweenCallback action) { }

	[Address(RVA = "0x94F130", Offset = "0x94E530", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x600024F")]
	public static T OnStepComplete(T t, TweenCallback action) { }

	[Address(RVA = "0x94F160", Offset = "0x94E560", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x600024E")]
	public static T OnUpdate(T t, TweenCallback action) { }

	[Address(RVA = "0x94F190", Offset = "0x94E590", Length = "0x33")]
	[Extension]
	[Token(Token = "0x6000252")]
	public static T OnWaypointChange(T t, TweenCallback<Int32> action) { }

	[Address(RVA = "0x660100", Offset = "0x65F500", Length = "0x1E4")]
	[Extension]
	[Token(Token = "0x6000256")]
	public static Sequence Prepend(Sequence s, Tween t) { }

	[Address(RVA = "0x65FF80", Offset = "0x65F380", Length = "0x67")]
	[Extension]
	[Token(Token = "0x600025C")]
	public static Sequence PrependCallback(Sequence s, TweenCallback callback) { }

	[Address(RVA = "0x65FFF0", Offset = "0x65F3F0", Length = "0x10C")]
	[Extension]
	[Token(Token = "0x600025A")]
	public static Sequence PrependInterval(Sequence s, float interval) { }

	[Address(RVA = "0x94F420", Offset = "0x94E820", Length = "0x264")]
	[Extension]
	[Token(Token = "0x6000254")]
	public static T SetAs(T t, TweenParams tweenParams) { }

	[Address(RVA = "0x94F1D0", Offset = "0x94E5D0", Length = "0x248")]
	[Extension]
	[Token(Token = "0x6000253")]
	public static T SetAs(T t, Tween asTween) { }

	[Address(RVA = "0x94F690", Offset = "0x94EA90", Length = "0x22")]
	[Extension]
	[Token(Token = "0x6000234")]
	public static T SetAutoKill(T t) { }

	[Address(RVA = "0x94F6C0", Offset = "0x94EAC0", Length = "0x21")]
	[Extension]
	[Token(Token = "0x6000235")]
	public static T SetAutoKill(T t, bool autoKillOnCompletion) { }

	[Address(RVA = "0x94F6F0", Offset = "0x94EAF0", Length = "0xAF")]
	[Extension]
	[Token(Token = "0x6000267")]
	public static T SetDelay(T t, float delay, bool asPrependedIntervalIfSequence) { }

	[Address(RVA = "0x94F7A0", Offset = "0x94EBA0", Length = "0x98")]
	[Extension]
	[Token(Token = "0x6000266")]
	public static T SetDelay(T t, float delay) { }

	[Address(RVA = "0x94F920", Offset = "0x94ED20", Length = "0x3D")]
	[Extension]
	[Token(Token = "0x6000242")]
	public static T SetEase(T t, EaseFunction customEase) { }

	[Address(RVA = "0x94F960", Offset = "0x94ED60", Length = "0xCB")]
	[Extension]
	[Token(Token = "0x6000241")]
	public static T SetEase(T t, AnimationCurve animCurve) { }

	[Address(RVA = "0x94FE10", Offset = "0x94F210", Length = "0x83")]
	[Extension]
	[Token(Token = "0x6000240")]
	public static T SetEase(T t, Ease ease, float amplitude, float period) { }

	[Address(RVA = "0x94F840", Offset = "0x94EC40", Length = "0x6E")]
	[Extension]
	[Token(Token = "0x600023F")]
	public static T SetEase(T t, Ease ease, float overshoot) { }

	[Address(RVA = "0x94F8B0", Offset = "0x94ECB0", Length = "0x65")]
	[Extension]
	[Token(Token = "0x600023E")]
	public static T SetEase(T t, Ease ease) { }

	[Address(RVA = "0x94FED0", Offset = "0x94F2D0", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x6000237")]
	public static T SetId(T t, string stringId) { }

	[Address(RVA = "0x94FEA0", Offset = "0x94F2A0", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x6000236")]
	public static T SetId(T t, object objectId) { }

	[Address(RVA = "0x94FF00", Offset = "0x94F300", Length = "0x15")]
	[Extension]
	[Token(Token = "0x6000238")]
	public static T SetId(T t, int intId) { }

	[Address(RVA = "0x94FF20", Offset = "0x94F320", Length = "0x1E")]
	[Extension]
	[Token(Token = "0x6000249")]
	public static T SetInverted(T t, bool inverted) { }

	[Address(RVA = "0x94FF40", Offset = "0x94F340", Length = "0x1F")]
	[Extension]
	[Token(Token = "0x6000248")]
	public static T SetInverted(T t) { }

	[Address(RVA = "0x950050", Offset = "0x94F450", Length = "0xED")]
	[Extension]
	[Token(Token = "0x600023A")]
	public static T SetLink(T t, GameObject gameObject, LinkBehaviour behaviour) { }

	[Address(RVA = "0x94FF60", Offset = "0x94F360", Length = "0xE3")]
	[Extension]
	[Token(Token = "0x6000239")]
	public static T SetLink(T t, GameObject gameObject) { }

	[Address(RVA = "0x6603C0", Offset = "0x65F7C0", Length = "0xDD")]
	[Extension]
	[Token(Token = "0x600027E")]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null) { }

	[Address(RVA = "0x6604A0", Offset = "0x65F8A0", Length = "0x6A")]
	[Extension]
	[Token(Token = "0x600027C")]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null) { }

	[Address(RVA = "0x660750", Offset = "0x65FB50", Length = "0xC9")]
	[Extension]
	[Token(Token = "0x6000282")]
	private static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, OrientType orientType, Vector3 lookAtPosition, Transform lookAtTransform, float lookAhead, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null, bool stableZRotation = false) { }

	[Address(RVA = "0x6602F0", Offset = "0x65F6F0", Length = "0xC6")]
	[Extension]
	[Token(Token = "0x6000281")]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation) { }

	[Address(RVA = "0x6605F0", Offset = "0x65F9F0", Length = "0x67")]
	[Extension]
	[Token(Token = "0x600027D")]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation) { }

	[Address(RVA = "0x660510", Offset = "0x65F910", Length = "0xD3")]
	[Extension]
	[Token(Token = "0x6000280")]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null) { }

	[Address(RVA = "0x660660", Offset = "0x65FA60", Length = "0xE5")]
	[Extension]
	[Token(Token = "0x600027F")]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation) { }

	[Address(RVA = "0x9501B0", Offset = "0x94F5B0", Length = "0x6E")]
	[Extension]
	[Token(Token = "0x600023D")]
	public static T SetLoops(T t, int loops, LoopType loopType) { }

	[Address(RVA = "0x950140", Offset = "0x94F540", Length = "0x67")]
	[Extension]
	[Token(Token = "0x600023C")]
	public static T SetLoops(T t, int loops) { }

	[Address(RVA = "0x6608A0", Offset = "0x65FCA0", Length = "0x1E")]
	[Extension]
	[Token(Token = "0x6000273")]
	public static Tweener SetOptions(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true) { }

	[Address(RVA = "0x660860", Offset = "0x65FC60", Length = "0x18")]
	[Extension]
	[Token(Token = "0x6000274")]
	public static Tweener SetOptions(TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly) { }

	[Address(RVA = "0x660860", Offset = "0x65FC60", Length = "0x18")]
	[Extension]
	[Token(Token = "0x6000275")]
	public static Tweener SetOptions(TweenerCore<Rect, Rect, RectOptions> t, bool snapping) { }

	[Address(RVA = "0x660820", Offset = "0x65FC20", Length = "0x1F")]
	[Extension]
	[Token(Token = "0x6000272")]
	public static Tweener SetOptions(TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false) { }

	[Address(RVA = "0x660840", Offset = "0x65FC40", Length = "0x18")]
	[Extension]
	[Token(Token = "0x6000271")]
	public static Tweener SetOptions(TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping) { }

	[Address(RVA = "0x660A40", Offset = "0x65FE40", Length = "0x1F")]
	[Extension]
	[Token(Token = "0x6000270")]
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false) { }

	[Address(RVA = "0x660A20", Offset = "0x65FE20", Length = "0x18")]
	[Extension]
	[Token(Token = "0x600026F")]
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping) { }

	[Address(RVA = "0x6609F0", Offset = "0x65FDF0", Length = "0x28")]
	[Extension]
	[Token(Token = "0x6000279")]
	public static Tweener SetOptions(TweenerCore<Vector2, Vector2, CircleOptions> t, float endValueDegrees, bool relativeCenter = true, bool snapping = false) { }

	[Address(RVA = "0x660880", Offset = "0x65FC80", Length = "0x18")]
	[Extension]
	[Token(Token = "0x600026D")]
	public static Tweener SetOptions(TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping) { }

	[Address(RVA = "0x660A60", Offset = "0x65FE60", Length = "0x18")]
	[Extension]
	[Token(Token = "0x600026C")]
	public static Tweener SetOptions(TweenerCore<Single, Single, FloatOptions> t, bool snapping) { }

	[Address(RVA = "0x660AB0", Offset = "0x65FEB0", Length = "0x1F")]
	[Extension]
	[Token(Token = "0x6000278")]
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false) { }

	[Address(RVA = "0x660A80", Offset = "0x65FE80", Length = "0x26")]
	[Extension]
	[Token(Token = "0x600027A")]
	public static TweenerCore<Vector3, Path, PathOptions> SetOptions(TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = 0) { }

	[Address(RVA = "0x6608C0", Offset = "0x65FCC0", Length = "0xF1")]
	[Extension]
	[Token(Token = "0x6000276")]
	public static Tweener SetOptions(TweenerCore<String, String, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = 0, string scrambleChars = null) { }

	[Address(RVA = "0x6609C0", Offset = "0x65FDC0", Length = "0x26")]
	[Extension]
	[Token(Token = "0x600027B")]
	public static TweenerCore<Vector3, Path, PathOptions> SetOptions(TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = 0, AxisConstraint lockRotation = 0) { }

	[Address(RVA = "0x660AB0", Offset = "0x65FEB0", Length = "0x1F")]
	[Extension]
	[Token(Token = "0x600026E")]
	public static Tweener SetOptions(TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false) { }

	[Address(RVA = "0x660880", Offset = "0x65FC80", Length = "0x18")]
	[Extension]
	[Token(Token = "0x6000277")]
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping) { }

	[Address(RVA = "0x660AD0", Offset = "0x65FED0", Length = "0x39E")]
	[Extension]
	[Token(Token = "0x6000283")]
	private static void SetPathForwardDirection(TweenerCore<Vector3, Path, PathOptions> t, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null) { }

	[Address(RVA = "0x950220", Offset = "0x94F620", Length = "0x19")]
	[Extension]
	[Token(Token = "0x6000243")]
	public static T SetRecyclable(T t) { }

	[Address(RVA = "0x950240", Offset = "0x94F640", Length = "0x18")]
	[Extension]
	[Token(Token = "0x6000244")]
	public static T SetRecyclable(T t, bool recyclable) { }

	[Address(RVA = "0x950260", Offset = "0x94F660", Length = "0x34")]
	[Extension]
	[Token(Token = "0x6000268")]
	public static T SetRelative(T t) { }

	[Address(RVA = "0x9502A0", Offset = "0x94F6A0", Length = "0x33")]
	[Extension]
	[Token(Token = "0x6000269")]
	public static T SetRelative(T t, bool isRelative) { }

	[Address(RVA = "0x9502E0", Offset = "0x94F6E0", Length = "0x22")]
	[Extension]
	[Token(Token = "0x600026A")]
	public static T SetSpeedBased(T t) { }

	[Address(RVA = "0x950310", Offset = "0x94F710", Length = "0x21")]
	[Extension]
	[Token(Token = "0x600026B")]
	public static T SetSpeedBased(T t, bool isSpeedBased) { }

	[Address(RVA = "0x950340", Offset = "0x94F740", Length = "0x160")]
	[Extension]
	[Token(Token = "0x600023B")]
	public static T SetTarget(T t, object target) { }

	[Address(RVA = "0x9504B0", Offset = "0x94F8B0", Length = "0xAD")]
	[Extension]
	[Token(Token = "0x6000245")]
	public static T SetUpdate(T t, bool isIndependentUpdate) { }

	[Address(RVA = "0x9505E0", Offset = "0x94F9E0", Length = "0xAD")]
	[Extension]
	[Token(Token = "0x6000246")]
	public static T SetUpdate(T t, UpdateType updateType) { }

	[Address(RVA = "0x950560", Offset = "0x94F960", Length = "0x7B")]
	[Extension]
	[Token(Token = "0x6000247")]
	public static T SetUpdate(T t, UpdateType updateType, bool isIndependentUpdate) { }

	[Address(RVA = "0x660E70", Offset = "0x660270", Length = "0x9D")]
	[Token(Token = "0x600025E")]
	private static bool ValidateAddToSequence(Sequence s, Tween t, bool ignoreTween = false) { }

}

