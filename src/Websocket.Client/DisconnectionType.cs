﻿namespace Websocket.Client
{
    /// <summary>
    /// Type that specify happenend disconnection
    /// </summary>
    public enum DisconnectionType
    {
        /// <summary>
        /// Type used for exit event, disposing of the websocket client
        /// </summary>
        Exit = 0,

        /// <summary>
        /// Type used when connection to websocket was lost in meantime
        /// </summary>
        Lost = 1,

        /// <summary>
        /// Type used when connection to websocket was lost by not receiving any message in given timerange
        /// </summary>
        NoMessageReceived = 2, 

        /// <summary>
        /// Type used when connection or reconnection returned error
        /// </summary>
        Error = 3,

        /// <summary>
        /// Type used when disconnection was requested by user
        /// </summary>
        ByUser = 4
    }
}
