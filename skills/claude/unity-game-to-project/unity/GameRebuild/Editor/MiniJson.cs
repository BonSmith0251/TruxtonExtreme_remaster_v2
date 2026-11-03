// Minimal JSON reader/writer for the rebuild graph (no package dependencies).
// Objects -> Dictionary<string, object>, arrays -> List<object>,
// integers -> long, other numbers -> double (NaN/Infinity accepted).
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GameRebuild
{
    public static class MiniJson
    {
        public static object Parse(string json)
        {
            int i = 0;
            var v = ParseValue(json, ref i);
            return v;
        }

        static void Ws(string s, ref int i)
        {
            while (i < s.Length && char.IsWhiteSpace(s[i])) i++;
        }

        static object ParseValue(string s, ref int i)
        {
            Ws(s, ref i);
            if (i >= s.Length) throw new FormatException("unexpected end of json");
            char c = s[i];
            switch (c)
            {
                case '{': return ParseObject(s, ref i);
                case '[': return ParseArray(s, ref i);
                case '"': return ParseString(s, ref i);
                case 't': i += 4; return true;
                case 'f': i += 5; return false;
                case 'n': i += 4; return null;
                case 'N': i += 3; return double.NaN;
                case 'I': i += 8; return double.PositiveInfinity;
                default:
                    if (c == '-' && i + 1 < s.Length && s[i + 1] == 'I') { i += 9; return double.NegativeInfinity; }
                    return ParseNumber(s, ref i);
            }
        }

        static Dictionary<string, object> ParseObject(string s, ref int i)
        {
            var d = new Dictionary<string, object>();
            i++;
            Ws(s, ref i);
            if (s[i] == '}') { i++; return d; }
            while (true)
            {
                Ws(s, ref i);
                var key = ParseString(s, ref i);
                Ws(s, ref i);
                i++; // :
                d[key] = ParseValue(s, ref i);
                Ws(s, ref i);
                if (s[i] == ',') { i++; continue; }
                i++; // }
                return d;
            }
        }

        static List<object> ParseArray(string s, ref int i)
        {
            var l = new List<object>();
            i++;
            Ws(s, ref i);
            if (s[i] == ']') { i++; return l; }
            while (true)
            {
                l.Add(ParseValue(s, ref i));
                Ws(s, ref i);
                if (s[i] == ',') { i++; continue; }
                i++; // ]
                return l;
            }
        }

        static string ParseString(string s, ref int i)
        {
            var sb = new StringBuilder();
            i++;
            while (true)
            {
                char c = s[i++];
                if (c == '"') return sb.ToString();
                if (c != '\\') { sb.Append(c); continue; }
                char e = s[i++];
                switch (e)
                {
                    case 'n': sb.Append('\n'); break;
                    case 't': sb.Append('\t'); break;
                    case 'r': sb.Append('\r'); break;
                    case 'b': sb.Append('\b'); break;
                    case 'f': sb.Append('\f'); break;
                    case 'u': sb.Append((char)Convert.ToInt32(s.Substring(i, 4), 16)); i += 4; break;
                    default: sb.Append(e); break;
                }
            }
        }

        static object ParseNumber(string s, ref int i)
        {
            int start = i;
            bool isFloat = false;
            while (i < s.Length && "+-0123456789.eE".IndexOf(s[i]) >= 0)
            {
                if (s[i] == '.' || s[i] == 'e' || s[i] == 'E') isFloat = true;
                i++;
            }
            var t = s.Substring(start, i - start);
            if (!isFloat && long.TryParse(t, NumberStyles.Integer, CultureInfo.InvariantCulture, out var l)) return l;
            if (!isFloat && ulong.TryParse(t, NumberStyles.Integer, CultureInfo.InvariantCulture, out var ul)) return (double)ul;
            return double.Parse(t, NumberStyles.Float, CultureInfo.InvariantCulture);
        }

        // ------------------------------------------------------------ writer
        public static string Serialize(object o)
        {
            var sb = new StringBuilder();
            Write(sb, o, 0);
            return sb.ToString();
        }

        static void Write(StringBuilder sb, object o, int indent)
        {
            switch (o)
            {
                case null: sb.Append("null"); break;
                case string s: WriteString(sb, s); break;
                case bool b: sb.Append(b ? "true" : "false"); break;
                case IDictionary d:
                    sb.Append("{");
                    bool first = true;
                    foreach (DictionaryEntry kv in d)
                    {
                        sb.Append(first ? "\n" : ",\n").Append(' ', indent + 1);
                        first = false;
                        WriteString(sb, kv.Key.ToString());
                        sb.Append(": ");
                        Write(sb, kv.Value, indent + 1);
                    }
                    if (!first) sb.Append("\n").Append(' ', indent);
                    sb.Append("}");
                    break;
                case IEnumerable e:
                    sb.Append("[");
                    bool f2 = true;
                    foreach (var x in e)
                    {
                        if (!f2) sb.Append(", ");
                        f2 = false;
                        Write(sb, x, indent + 1);
                    }
                    sb.Append("]");
                    break;
                case float fl: sb.Append(fl.ToString("R", CultureInfo.InvariantCulture)); break;
                case double db: sb.Append(db.ToString("R", CultureInfo.InvariantCulture)); break;
                default: sb.Append(Convert.ToString(o, CultureInfo.InvariantCulture)); break;
            }
        }

        static void WriteString(StringBuilder sb, string s)
        {
            sb.Append('"');
            foreach (var c in s)
            {
                if (c == '"' || c == '\\') sb.Append('\\').Append(c);
                else if (c < 32) sb.AppendFormat("\\u{0:x4}", (int)c);
                else sb.Append(c);
            }
            sb.Append('"');
        }
    }
}
