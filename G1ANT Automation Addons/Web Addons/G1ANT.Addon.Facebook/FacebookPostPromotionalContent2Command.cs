using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Facebook
{
    [Command(Name = "facebook.postpromotionalend", Tooltip = "This is a secondary command used separately to confirm the data that needs to be posted.")]
    public class FacebookPostPromotionalContent2Command : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            
        }

        public FacebookPostPromotionalContent2Command(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            arguments.Search.Value = "body > div.l9j0dhe7.tkr6xdv7 > div.rq0escxv.l9j0dhe7.du4w35lb > div > div.iqfcb0g7.tojvnm2t.a6sixzi8.k5wvi7nf.q3lfd5jv.pk4s997a.bipmatt0.cebpdrjk.qowsmv63.owwhemhu.dp1hu0rb.dhp61c6y.l9j0dhe7.iyyx5f41.a8s20v7p > div > div > div > form > div > div.kr520xx4.pedkr2u6.ms05siws.pnx7fd3z.b7h9ocf4.pmk7jnqg.j9ispegn > div > div.j83agx80.cbu4d94t.f0kvp8a6.mfofr4af.l9j0dhe7.oh7imozk > div.ihqw7lf3.discj3wi.l9j0dhe7 > div.k4urcfbm.dati1w0a.hv4rvrfc.i1fnvgqd.j83agx80.rq0escxv.bp9cbjyn.discj3wi > div";
            arguments.By.Value = "cssselector";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);
        }
    }
}