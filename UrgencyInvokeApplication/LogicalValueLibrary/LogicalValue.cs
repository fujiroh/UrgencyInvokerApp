using System;

namespace LogicalValueLibrary
{
    public class LogicalValue : IEquatable<LogicalValue>
    {
        // 有効数字指定
        private const int _ValidDigit = 6;
        private readonly double _value;

        public static LogicalValue Zero => new LogicalValue(0D);
        public static LogicalValue Invalid => new LogicalValue(double.NaN);
        
        public double Value => _value;

        public static LogicalValue Create(double value)
        {
            return new LogicalValue(value);
        }

        private LogicalValue(double value)
        {
            _value = Math.Round(value, _ValidDigit);
        }

        public static LogicalValue Pow(LogicalValue value, int pow)
        {
            return new LogicalValue(Math.Pow(value._value, pow));
        }

        # region 四則演算

        public static LogicalValue operator +(LogicalValue value1, LogicalValue value2)
        {
            return new LogicalValue(value1._value + value2._value);
        }

        public static LogicalValue operator -(LogicalValue value1, LogicalValue value2)
        {
            return new LogicalValue(value1._value - value2._value);
        }

        public static LogicalValue operator *(LogicalValue value1, LogicalValue value2)
        {
            return new LogicalValue(value1._value * value2._value);
        }

        public static LogicalValue operator *(LogicalValue value1, double value2)
        {
            return new LogicalValue(value1._value * value2);
        }

        public static LogicalValue operator /(LogicalValue value1, LogicalValue value2)
        {
            return new LogicalValue(value1._value / value2._value);
        }

        public static bool operator ==(LogicalValue value1, LogicalValue value2)
        {
            return value1 != null && value1.Equals(value2);
        }

        public static bool operator !=(LogicalValue value1, LogicalValue value2)
        {
            return !(value1 == value2);
        }

        #endregion

        public bool Equals(LogicalValue other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _value.Equals(other._value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((LogicalValue) obj);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}