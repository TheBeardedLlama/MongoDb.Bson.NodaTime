﻿using NodaTime;
using NodaTime.Text;

namespace MongoDb.Bson.NodaTime
{
    public class OffsetDateTimeSerializer : PatternSerializer<OffsetDateTime>
    {
        public OffsetDateTimeSerializer() : base(OffsetDateTimePattern.ExtendedIsoPattern, d => d.WithCalendar(CalendarSystem.Iso))
        { }
    }
}