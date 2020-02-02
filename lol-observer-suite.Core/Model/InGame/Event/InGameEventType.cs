using System;

namespace lol_observer_suite.Core.Model.InGame.Event
{
    public enum InGameEventType
    {
        [EventTypeDescriptor(typeof(InGameEvent))]
        GameStart,

        [EventTypeDescriptor(typeof(InGameEvent))]
        MinionsSpawning,

        [EventTypeDescriptor(typeof(InGameChampionKillEvent))]
        ChampionKill,

        [EventTypeDescriptor(typeof(InGameFirstBloodEvent))]
        FirstBlood,

        [EventTypeDescriptor(typeof(InGameTurretKillEvent))]
        TurretKilled,

        [EventTypeDescriptor(typeof(InGameKillEvent))]
        FirstBrick,

        [EventTypeDescriptor(typeof(InGameMultiKillEvent))]
        Multikill,

        [EventTypeDescriptor(typeof(InGameInhibKillEvent))]
        InhibKilled,

        // Could be more
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class EventTypeDescriptorAttribute : Attribute
    {
        public Type MappingClass { get; set; }

        public EventTypeDescriptorAttribute(Type mappingClass)
        {
            MappingClass = mappingClass;
        }
    }
}
