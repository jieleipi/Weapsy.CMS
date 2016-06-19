#region Copyright

//  Weapsy - http://www.weapsy.org
//  Copyright (c) 2011-2013 Luca Briguglia
//  Licensed under the Weapsy Public License Version 1.0 (WPL-1.0)
//  A copy of this license may be found at http://www.weapsy.org/license

#endregion

using System.Collections.Generic;

namespace Weapsy.Entities
{
    public class MailTemplateType : BaseAuditEntity
    {
        public MailTemplateType()
        {
            MailTemplates = new HashSet<MailTemplate>();
        }

        public int AppId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TokenController { get; set; }
        public string TokenAction { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<MailTemplate> MailTemplates { get; set; }
    }
}