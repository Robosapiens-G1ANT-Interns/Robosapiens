using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Facebook
{
    [Command(Name = "facebook.sendmessage", Tooltip = "This command is used to send messages to an account on facebook.")]
    public class FacebookSendMessageCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "Contact Name", Required = true, Tooltip = "Enter the keyword that you want to search and send the request to.")]
            public TextStructure Contact { get; set; }

            [Argument(Name = "Custom Message", Required = true, Tooltip = "Enter the keyword that you want to search and send the request to.")]
            public TextStructure Message { get; set; }

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public FacebookSendMessageCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("www.facebook.com", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "/html/body/div[1]/div/div[1]/div[1]/div[2]/div[2]/div/div/div/div/div[3]/label/input";
            arguments.By.Value = "xpath";
            SeleniumManager.CurrentWrapper.TypeText(arguments.Contact.Value, arguments, arguments.Timeout.Value);

            SeleniumManager.CurrentWrapper.PressKey("enter", arguments, arguments.Timeout.Value);

            arguments.Search.Value = "#mount_0_0 > div > div:nth-child(1) > div.rq0escxv.l9j0dhe7.du4w35lb > div.rq0escxv.l9j0dhe7.du4w35lb > div > div > div.j83agx80.cbu4d94t.d6urw2fd.dp1hu0rb.l9j0dhe7.du4w35lb > div.rq0escxv.l9j0dhe7.du4w35lb.j83agx80.pfnyh3mw.jifvfom9.gs1a9yip.owycx6da.btwxx1t3.buofh1pr.dp1hu0rb.ka73uehy > div.rq0escxv.l9j0dhe7.du4w35lb.j83agx80.cbu4d94t.d2edcug0.rj1gh0hx.buofh1pr.g5gj957u.hpfvmrgz.dp1hu0rb > div > div > div > div > div > div > div:nth-child(1) > div > div > div > div:nth-child(1) > div.dhix69tm.sjgh65i0.wkznzc2l.tr9rh885 > div.qu0x051f.f10w8fjw.jb3vyjys > div > div > div.hpfvmrgz.g5gj957u.buofh1pr.rj1gh0hx.o8rfisnq > div > div > span > div > a";
            arguments.By.Value = "cssselector";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);


            arguments.Search.Value = "#mount_0_0 > div > div:nth-child(1) > div.rq0escxv.l9j0dhe7.du4w35lb > div.rq0escxv.l9j0dhe7.du4w35lb > div > div > div.j83agx80.cbu4d94t.d6urw2fd.dp1hu0rb.l9j0dhe7.du4w35lb > div.dp1hu0rb.cbu4d94t.j83agx80 > div > div > div.rq0escxv.lpgh02oy.du4w35lb.rek2kq2y > div > div > div > div.rq0escxv.l9j0dhe7.du4w35lb.j83agx80.cbu4d94t.d2edcug0.o8rfisnq > div > div > div:nth-child(2) > div > span > div";
            arguments.By.Value = "cssselector";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);

            arguments.Search.Value = "#mount_0_0 > div > div:nth-child(1) > div.rq0escxv.l9j0dhe7.du4w35lb > div.poy2od1o.i09qtzwb.n7fi1qx3 > div.l9j0dhe7.fh5enmmv > div.l9j0dhe7.tkr6xdv7 > div.j83agx80.l9j0dhe7.du4w35lb.aovydwv3.do00u71z > div > div > div > div > div > div > div.rj1gh0hx.buofh1pr.j83agx80.cbu4d94t.l9j0dhe7.du4w35lb > div > div.pfnyh3mw > form > div > div.j83agx80.l9j0dhe7.aovydwv3.ni8dbmo4.stjgntxs.nred35xi.n8tt0mok.hyh9befq > div.aovydwv3.j83agx80.buofh1pr.ni8dbmo4.cxgpxx05.sj5x9vvc.qio8uep8.l9j0dhe7 > div.orhb3f3m.h905i5nu.jinzq4gt.emzo65vh.dflh9lhu.e5nlhep0.ecm0bbzt.h4z51re5.gvyehdmr.mu0vl6fp.msuhji6j.iqy7zqfr.rj1gh0hx.cbu4d94t.buofh1pr.j83agx80.ni8dbmo4.ll8tlv6m.b3i9ofy5.oo9gr5id.flx89l3n.dpja2al7.hedjyaoh > div > div > div > div > div._5rpb > div";
            arguments.By.Value = "cssselector";
            SeleniumManager.CurrentWrapper.TypeText(arguments.Message.Value, arguments, arguments.Timeout.Value);

            arguments.Search.Value = "#mount_0_0 > div > div:nth-child(1) > div.rq0escxv.l9j0dhe7.du4w35lb > div.poy2od1o.i09qtzwb.n7fi1qx3 > div.l9j0dhe7.fh5enmmv > div.l9j0dhe7.tkr6xdv7 > div.j83agx80.l9j0dhe7.du4w35lb.aovydwv3.do00u71z > div > div > div > div > div > div > div.rj1gh0hx.buofh1pr.j83agx80.cbu4d94t.l9j0dhe7.du4w35lb > div > div.pfnyh3mw > form > div > div.j83agx80.l9j0dhe7.aovydwv3.ni8dbmo4.stjgntxs.nred35xi.n8tt0mok.hyh9befq > span:nth-child(4) > div";
            arguments.By.Value = "cssselector";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);

            SeleniumManager.CurrentWrapper.Navigate("www.facebook.com", arguments.Timeout.Value, arguments.NoWait.Value);
        }
    }
}