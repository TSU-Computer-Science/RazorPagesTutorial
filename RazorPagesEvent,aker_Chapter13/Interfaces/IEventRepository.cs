﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesEventMaker_Chapter13
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
        void AddEvent(Event ev);
        void DeleteEvent(int id);
        void UpdateEvent(Event ev);
        List<Event> FilterEvents(string city);
        List<Event> SearchEventsByCode(string code);

    }
}
