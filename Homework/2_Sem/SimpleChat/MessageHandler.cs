using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SimpleChat
{
    public delegate void MessageHandler(Message message);

    public delegate void UserCountChanged(object sender, int newCountUsers);
}