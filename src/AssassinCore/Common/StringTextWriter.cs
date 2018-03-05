
using System;
using System.Text;

namespace AssassinCore.Common
{
    public sealed class StringTextWriter
    {
        private static readonly string NewLine = Environment.NewLine;

        private readonly StringBuilder _writer;

        public StringTextWriter()
        {
            _writer = new StringBuilder();
        }

        public StringTextWriter(int capacity)
        {
            _writer = new StringBuilder(capacity);
        }

        public StringTextWriter(string value)
        {
            _writer = new StringBuilder(value);
        }

        public StringTextWriter(int capacity, int maxCapacity)
        {
            _writer = new StringBuilder(capacity, maxCapacity);
        }

        public StringTextWriter(string value, int capacity)
        {
            _writer = new StringBuilder(value, capacity);
        }

        public StringTextWriter(string value, int startIndex, int length, int capacity)
        {
            _writer = new StringBuilder(value, startIndex, length, capacity);
        }

        public int Capacity => _writer.Capacity;

        public int Length => _writer.Length;

        public int MaxCapacity => _writer.MaxCapacity;

        public StringTextWriter Write(byte value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(ushort value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(uint value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(ulong value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(sbyte value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(short value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(int value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(long value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(float value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(double value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(decimal value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(bool value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(char value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(char value, int repeatCount)
        {
            _writer.Append(value, repeatCount);
            return this;
        }

        public StringTextWriter Write(char[] value, int startIndex, int charCount)
        {
            _writer.Append(value, startIndex, charCount);
            return this;
        }

        public StringTextWriter Write(string value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter Write(string value, int startIndex, int count)
        {
            _writer.Append(value, startIndex, count);
            return this;
        }

        public StringTextWriter Write(object value)
        {
            _writer.Append(value);
            return this;
        }

        public StringTextWriter WriteLine()
        {
            _writer.Append(NewLine);
            return this;
        }

        public StringTextWriter WriteLine(byte value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(ushort value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(uint value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(ulong value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(sbyte value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(short value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(int value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(long value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(float value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(double value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(decimal value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(bool value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(char value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(char value, int repeatCount)
        {
            Write(value, repeatCount);
            return WriteLine();
        }

        public StringTextWriter WriteLine(char[] value, int startIndex, int charCount)
        {
            Write(value, startIndex, charCount);
            return WriteLine();
        }

        public StringTextWriter WriteLine(string value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter WriteLine(string value, int startIndex, int count)
        {
            Write(value, startIndex, count);
            return WriteLine();
        }

        public StringTextWriter WriteLine(object value)
        {
            Write(value);
            return WriteLine();
        }

        public StringTextWriter Remove(int startIndex, int length)
        {
            _writer.Remove(startIndex, length);
            return this;
        }

        public StringTextWriter Replace(char oldChar, char newChar)
        {
            _writer.Replace(oldChar, newChar);
            return this;
        }

        public StringTextWriter Replace(char oldChar, char newChar, int startIndex, int count)
        {
            _writer.Replace(oldChar, newChar, startIndex, count);
            return this;
        }

        public StringTextWriter Replace(string oldValue, string newValue)
        {
            _writer.Replace(oldValue, newValue);
            return this;
        }

        public StringTextWriter Replace(string oldValue, string newValue, int startIndex, int count)
        {
            _writer.Replace(oldValue, newValue, startIndex, count);
            return this;
        }

        public StringTextWriter Clear()
        {
            _writer.Clear();
            return this;
        }

        public string ToStringWithClear()
        {
            var value = ToString();
            Clear();
            return value;
        }

        public string ToStringWithClear(int startIndex, int length)
        {
            var value = ToString(startIndex, length);
            Clear();
            return value;
        }

        public string ToString(int startIndex, int length)
        {
            return _writer.ToString(startIndex, length);
        }

        public override string ToString()
        {
            return _writer.ToString();
        }

        public static StringTextWriter operator +(StringTextWriter left, string right)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }

            left.Write(right);
            return left;
        }

        public static StringTextWriter operator +(string left, StringTextWriter right)
        {
            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }

            right.Write(left);
            return right;
        }
    }
}