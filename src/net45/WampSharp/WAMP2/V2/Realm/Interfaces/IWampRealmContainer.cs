﻿namespace WampSharp.V2.Realm
{
    public interface IWampRealmContainer
    {
        IWampRealm GetRealmByName(string name);
    }

    public interface IWampRealmContainer<TMessage>
    {
        IWampRealm<TMessage> GetRealmByName(string name);
    }
}