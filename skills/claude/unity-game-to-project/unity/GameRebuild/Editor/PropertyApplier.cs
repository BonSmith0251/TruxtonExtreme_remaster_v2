// Writes dumped type-tree data onto any UnityEngine.Object through SerializedObject.
// Type-tree field names equal SerializedProperty names, so one generic walker
// covers built-in components, script fields, materials and project settings.
using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor;
using UnityEngine;

namespace GameRebuild
{
    public class PropertyApplier
    {
        public Func<string, UnityEngine.Object> Resolve;
        public readonly Dictionary<string, int> Unresolved = new Dictionary<string, int>();
        public readonly Dictionary<string, int> Unsupported = new Dictionary<string, int>();
        public int Assigned;

        public void Apply(UnityEngine.Object target, Dictionary<string, object> data, ICollection<string> skip)
        {
            if (target == null || data == null) return;
            var so = new SerializedObject(target);
            var it = so.GetIterator();
            if (!it.Next(true)) return;
            do
            {
                if (skip != null && skip.Contains(it.name)) continue;
                if (!data.TryGetValue(it.name, out var v)) continue;
                try { Assign(it.Copy(), v); }
                catch (Exception e) { Count(Unsupported, target.GetType().Name + "." + it.name + ": " + e.GetType().Name); }
            } while (it.Next(false));
            so.ApplyModifiedPropertiesWithoutUndo();
        }

        static void Count(Dictionary<string, int> d, string k)
        {
            d.TryGetValue(k, out var n);
            d[k] = n + 1;
        }

        public void Assign(SerializedProperty p, object v)
        {
            if (v == null)
            {
                if (p.propertyType == SerializedPropertyType.ObjectReference) p.objectReferenceValue = null;
                return;
            }
            var d = v as Dictionary<string, object>;
            switch (p.propertyType)
            {
                case SerializedPropertyType.Integer:
                case SerializedPropertyType.Character:
                    if (p.type == "ulong" || p.type == "UInt64") p.ulongValue = Convert.ToUInt64(Num(v));
                    else if (p.type == "uint" || p.type == "UInt32") p.longValue = (long)(uint)Convert.ToInt64(Num(v));
                    else if (p.type == "int" || p.type == "SInt32") p.intValue = unchecked((int)Convert.ToInt64(Num(v)));
                    else p.longValue = Convert.ToInt64(Num(v));
                    break;
                case SerializedPropertyType.Boolean: p.boolValue = Convert.ToDouble(Num(v)) != 0; break;
                case SerializedPropertyType.Float: p.doubleValue = Convert.ToDouble(Num(v)); break;
                case SerializedPropertyType.String: p.stringValue = v as string ?? Convert.ToString(v, CultureInfo.InvariantCulture); break;
                case SerializedPropertyType.Enum: p.intValue = Convert.ToInt32(Num(v)); break;
                case SerializedPropertyType.LayerMask:
                    // masks are stored as uint (0xFFFFFFFF = Everything)
                    p.intValue = unchecked((int)Convert.ToInt64(Num(d != null ? d["m_Bits"] : v)));
                    break;
                case SerializedPropertyType.Color: p.colorValue = new Color(F(d, "r"), F(d, "g"), F(d, "b"), F(d, "a")); break;
                case SerializedPropertyType.Vector2: p.vector2Value = new Vector2(F(d, "x"), F(d, "y")); break;
                case SerializedPropertyType.Vector3: p.vector3Value = new Vector3(F(d, "x"), F(d, "y"), F(d, "z")); break;
                case SerializedPropertyType.Vector4: p.vector4Value = new Vector4(F(d, "x"), F(d, "y"), F(d, "z"), F(d, "w")); break;
                case SerializedPropertyType.Quaternion: p.quaternionValue = new Quaternion(F(d, "x"), F(d, "y"), F(d, "z"), F(d, "w")); break;
                case SerializedPropertyType.Vector2Int: p.vector2IntValue = new Vector2Int(I(d, "x"), I(d, "y")); break;
                case SerializedPropertyType.Vector3Int: p.vector3IntValue = new Vector3Int(I(d, "x"), I(d, "y"), I(d, "z")); break;
                case SerializedPropertyType.Rect: p.rectValue = new Rect(F(d, "x"), F(d, "y"), F(d, "width"), F(d, "height")); break;
                case SerializedPropertyType.RectInt: p.rectIntValue = new RectInt(I(d, "x"), I(d, "y"), I(d, "width"), I(d, "height")); break;
                case SerializedPropertyType.Bounds:
                    p.boundsValue = new Bounds(V3(d["m_Center"]), V3(d["m_Extent"]) * 2f);
                    break;
                case SerializedPropertyType.ObjectReference:
                    if (d != null && d.TryGetValue("$ref", out var key))
                    {
                        var o = Resolve((string)key);
                        if (o == null) Count(Unresolved, (string)key);
                        else
                        {
                            p.objectReferenceValue = o;
                            // a type-incompatible value is silently dropped by Unity; detect it
                            if (p.objectReferenceValue == null) Count(Unresolved, (string)key + " (type mismatch: " + o.GetType().Name + ")");
                            else Assigned++;
                        }
                    }
                    break;
                case SerializedPropertyType.AnimationCurve: p.animationCurveValue = Curve(d); break;
                case SerializedPropertyType.Gradient: p.gradientValue = GradientFrom(d); break;
                case SerializedPropertyType.ArraySize:
                case SerializedPropertyType.FixedBufferSize:
                    break;
                case SerializedPropertyType.ManagedReference:
                    Count(Unsupported, "SerializeReference");
                    break;
                default:
                    AssignGeneric(p, v);
                    break;
            }
        }

        void AssignGeneric(SerializedProperty p, object v)
        {
            var list = v as List<object>;
            if (p.isArray && p.propertyType != SerializedPropertyType.String)
            {
                if (list == null) return;
                p.arraySize = list.Count;
                for (int i = 0; i < list.Count; i++) Assign(p.GetArrayElementAtIndex(i), list[i]);
                return;
            }
            var d = v as Dictionary<string, object>;
            if (d == null && list != null && list.Count == 2)
            {
                // UnityPy encodes map/pair entries as [first, second]
                d = new Dictionary<string, object> { { "first", list[0] }, { "second", list[1] } };
            }
            if (d == null) return;
            var c = p.Copy();
            var end = p.GetEndProperty();
            int depth = p.depth;
            if (!c.Next(true)) return;
            while (!SerializedProperty.EqualContents(c, end) && c.depth > depth)
            {
                if (c.depth == depth + 1 && d.TryGetValue(c.name, out var cv)) Assign(c.Copy(), cv);
                if (!c.Next(false)) break;
            }
        }

        // ------------------------------------------------------------ value helpers
        static object Num(object v)
        {
            if (v is bool b) return b ? 1L : 0L;
            if (v is string s) return double.Parse(s, CultureInfo.InvariantCulture);
            return v;
        }

        static float F(Dictionary<string, object> d, string k) =>
            d != null && d.TryGetValue(k, out var v) && v != null ? (float)Convert.ToDouble(Num(v)) : 0f;

        static int I(Dictionary<string, object> d, string k) =>
            d != null && d.TryGetValue(k, out var v) && v != null ? Convert.ToInt32(Num(v)) : 0;

        static Vector3 V3(object o)
        {
            var d = o as Dictionary<string, object>;
            return new Vector3(F(d, "x"), F(d, "y"), F(d, "z"));
        }

        static AnimationCurve Curve(Dictionary<string, object> d)
        {
            var c = new AnimationCurve();
            if (d == null) return c;
            if (d.TryGetValue("m_Curve", out var keys) && keys is List<object> kl)
            {
                var frames = new List<Keyframe>();
                foreach (var ko in kl)
                {
                    var k = ko as Dictionary<string, object>;
                    var kf = new Keyframe(F(k, "time"), F(k, "value"), F(k, "inSlope"), F(k, "outSlope"));
                    if (k.ContainsKey("inWeight"))
                    {
                        kf.weightedMode = (WeightedMode)I(k, "weightedMode");
                        kf.inWeight = F(k, "inWeight");
                        kf.outWeight = F(k, "outWeight");
                    }
                    frames.Add(kf);
                }
                c.keys = frames.ToArray();
            }
            c.preWrapMode = (WrapMode)I(d, "m_PreInfinity");
            c.postWrapMode = (WrapMode)I(d, "m_PostInfinity");
            return c;
        }

        static Gradient GradientFrom(Dictionary<string, object> d)
        {
            var g = new Gradient();
            if (d == null) return g;
            int nc = Math.Max(1, I(d, "m_NumColorKeys")), na = Math.Max(1, I(d, "m_NumAlphaKeys"));
            var ck = new GradientColorKey[nc];
            var ak = new GradientAlphaKey[na];
            for (int i = 0; i < nc; i++)
            {
                var col = d.TryGetValue("key" + i, out var kv) ? kv as Dictionary<string, object> : null;
                ck[i] = new GradientColorKey(new Color(F(col, "r"), F(col, "g"), F(col, "b")), I(d, "ctime" + i) / 65535f);
            }
            for (int i = 0; i < na; i++)
            {
                var col = d.TryGetValue("key" + i, out var kv) ? kv as Dictionary<string, object> : null;
                ak[i] = new GradientAlphaKey(F(col, "a"), I(d, "atime" + i) / 65535f);
            }
            g.SetKeys(ck, ak);
            g.mode = (GradientMode)I(d, "m_Mode");
            return g;
        }
    }
}
