using System;
using System.Collections.Generic;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Test
{
    class MQTT
    {
        public static MqttClient CreateConnection()
        {
            MqttClient myClient = new MqttClient("broker.mqttdashboard.com");
            // Register to message received
            myClient.MqttMsgPublishReceived += client_recievedMessage;

            string clientId = Guid.NewGuid().ToString();
            myClient.Connect(clientId);

            return myClient;
        }

        static void client_recievedMessage(object sender, MqttMsgPublishEventArgs e)
        {
            var message = System.Text.Encoding.Default.GetString(e.Message);
            System.Console.WriteLine("Message received: " + message + " " +e.Topic);
        }

        public static void subscribeToSensors(MqttClient myClient, String node)
        {
            myClient.Subscribe(new String[] { node+ "/Temperature" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            myClient.Subscribe(new String[] { node + "/Humidity" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            myClient.Subscribe(new String[] { node + "/COppm" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            myClient.Subscribe(new String[] { node + "/Hydrogenppm" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            myClient.Subscribe(new String[] { node + "/Smokeppm" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }
    }
}
