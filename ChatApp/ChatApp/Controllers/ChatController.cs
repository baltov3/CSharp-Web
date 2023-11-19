using ChatApp.Models.Message;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
       private static List<KeyValuePair<string, string>> _messages= new List<KeyValuePair<string, string>>();

        public IActionResult Show()
        {
            if (_messages.Count<1)
            {
                return View(new ChatViewModel());
            }
            var chatModel = new ChatViewModel()
            {
                Messages = _messages.Select(m=> new MessageViewModel()
                {
                    Sender=m.Key,
                    Messagetext=m.Value
                }).ToList()
            };
            return View(chatModel);
        }
        public IActionResult Send(ChatViewModel chat)
        {
            var newmessage = chat.CurrentMessage;

            _messages.Add(new KeyValuePair<string, string>(newmessage.Sender, newmessage.Messagetext));
            return RedirectToAction("Show");
        }
    }
}
