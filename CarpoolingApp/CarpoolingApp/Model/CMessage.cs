using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpoolingApp.Model
{
   public  class CMessage
    {
        public string Id { get; set; }
        public string ConversationId { get; set; }
        public string UserId { get; set; }
        public string CUsername { get; set; }
        public string Text { get; set; }
    }
}
