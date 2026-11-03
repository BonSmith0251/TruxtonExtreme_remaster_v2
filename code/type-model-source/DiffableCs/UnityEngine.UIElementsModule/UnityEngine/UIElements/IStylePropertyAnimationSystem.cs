namespace UnityEngine.UIElements;

[Token(Token = "0x2000456")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal interface IStylePropertyAnimationSystem
{

	[Token(Token = "0x60020AD")]
	public void CancelAllAnimations(VisualElement owner) { }

	[Token(Token = "0x60020AC")]
	public void CancelAllAnimations() { }

	[Token(Token = "0x60020AE")]
	public void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	[Token(Token = "0x60020B0")]
	public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds) { }

	[Token(Token = "0x6002099")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020AB")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, MaterialDefinition startValue, MaterialDefinition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020AA")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, List<FilterFunction> startValue, List<FilterFunction> endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A9")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A8")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A7")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A6")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Ratio startValue, Ratio endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A5")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A3")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A2")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A1")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A0")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600209F")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600209E")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600209C")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600209B")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600209A")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020A4")]
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x600209D")]
	public bool StartTransitionEnum(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Token(Token = "0x60020B1")]
	public void Update(double updateTimeInSeconds) { }

	[Token(Token = "0x60020AF")]
	public void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

}

