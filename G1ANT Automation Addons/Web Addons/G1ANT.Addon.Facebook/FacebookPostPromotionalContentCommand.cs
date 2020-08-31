using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Facebook
{
    [Command(Name = "facebook.postpromotionalcontent", Tooltip = "This command posts a promotional text, photo or video on the user's Facebook account.")]
    public class FacebookPostPromotionalContentCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "Message", Required = false, Tooltip = "Enter the message or text to be posted.")]
            public TextStructure Message { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Photo", Required = false, Tooltip = "Enter the file path of photo to be posted.")]
            public TextStructure Photo { get; set; } = new TextStructure(string.Empty);

            [Argument(Name = "Video", Required = false, Tooltip = "Enter the file path of video to be posted.")]
            public TextStructure Video { get; set; } = new TextStructure(string.Empty);

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public FacebookPostPromotionalContentCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            SeleniumManager.CurrentWrapper.Navigate("www.facebook.com", arguments.Timeout.Value, arguments.NoWait.Value);

            arguments.Search.Value = "#mount_0_0 > div > div:nth-child(1) > div.rq0escxv.l9j0dhe7.du4w35lb > div:nth-child(3) > div.n7fi1qx3.hv4rvrfc.b3onmgus.poy2od1o.kr520xx4.ehxjyohh > div.bp9cbjyn.j83agx80.rl25f0pe.byvelhso.l9j0dhe7.du4w35lb > div:nth-child(4) > span > div";
            arguments.By.Value = "cssselector";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);

            arguments.Search.Value = "#mount_0_0 > div > div:nth-child(1) > div.rq0escxv.l9j0dhe7.du4w35lb > div:nth-child(3) > div.n7fi1qx3.hv4rvrfc.b3onmgus.poy2od1o.kr520xx4.ehxjyohh > div:nth-child(2) > div > div:nth-child(2) > div.j34wkznp.qp9yad78.pmk7jnqg.kr520xx4 > div.iqfcb0g7.tojvnm2t.a6sixzi8.k5wvi7nf.q3lfd5jv.pk4s997a.bipmatt0.cebpdrjk.qowsmv63.owwhemhu.dp1hu0rb.dhp61c6y.l9j0dhe7.iyyx5f41.a8s20v7p > div > div > div > div > div > div > div > div.ecm0bbzt.rz4wbd8a.sj5x9vvc.a8nywdso > div:nth-child(1)";
            arguments.By.Value = "cssselector";
            SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);


            if (arguments.Message.Value != "")
            {
                arguments.Search.Value = "body > div.l9j0dhe7.tkr6xdv7 > div.rq0escxv.l9j0dhe7.du4w35lb > div > div.iqfcb0g7.tojvnm2t.a6sixzi8.k5wvi7nf.q3lfd5jv.pk4s997a.bipmatt0.cebpdrjk.qowsmv63.owwhemhu.dp1hu0rb.dhp61c6y.l9j0dhe7.iyyx5f41.a8s20v7p > div > div > div > form > div > div.kr520xx4.pedkr2u6.ms05siws.pnx7fd3z.b7h9ocf4.pmk7jnqg.j9ispegn > div > div.j83agx80.cbu4d94t.f0kvp8a6.mfofr4af.l9j0dhe7.oh7imozk > div.q5bimw55.rpm2j7zs.k7i0oixp.gvuykj2m.j83agx80.cbu4d94t.ni8dbmo4.eg9m0zos.l9j0dhe7.du4w35lb.ofs802cu.pohlnb88.dkue75c7.mb9wzai9.l56l04vs.r57mb794.kh7kg01d.c3g1iek1.buofh1pr > div.j83agx80.cbu4d94t.buofh1pr > div.o6r2urh6.buofh1pr.datstx6m.l9j0dhe7.oh7imozk > div.rq0escxv.buofh1pr.df2bnetk.hv4rvrfc.dati1w0a.l9j0dhe7.k4urcfbm.du4w35lb.o0xt3n8b.gbhij3x4 > div > div > div > div > div._5rpb > div";
                arguments.By.Value = "cssselector";
                SeleniumManager.CurrentWrapper.TypeText(arguments.Message.Value, arguments, arguments.Timeout.Value);
            }

            if (arguments.Photo.Value != "")
            {
                arguments.Search.Value = "body > div.l9j0dhe7.tkr6xdv7 > div.rq0escxv.l9j0dhe7.du4w35lb > div > div.iqfcb0g7.tojvnm2t.a6sixzi8.k5wvi7nf.q3lfd5jv.pk4s997a.bipmatt0.cebpdrjk.qowsmv63.owwhemhu.dp1hu0rb.dhp61c6y.l9j0dhe7.iyyx5f41.a8s20v7p > div > div > div > form > div > div.kr520xx4.pedkr2u6.ms05siws.pnx7fd3z.b7h9ocf4.pmk7jnqg.j9ispegn > div > div.j83agx80.cbu4d94t.f0kvp8a6.mfofr4af.l9j0dhe7.oh7imozk > div.ihqw7lf3.discj3wi.l9j0dhe7 > div.scb9dxdr.sj5x9vvc.dflh9lhu.cxgpxx05.dhix69tm.wkznzc2l.i1fnvgqd.j83agx80.rq0escxv.ibutc8p7.l82x9zwi.uo3d90p7.pw54ja7n.ue3kfks5.tr4kgdav.eip75gnj.ccnbzhu1.dwg5866k.cwj9ozl2.bp9cbjyn > div:nth-child(2) > div > div:nth-child(2) > span > div";
                arguments.By.Value = "cssselector";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);

                Scripter.Variables.SetVariableValue(arguments.Result.Value, new TextStructure (arguments.Photo.Value));
            }

            if (arguments.Video.Value != "")
            {
                arguments.Search.Value = "body > div.l9j0dhe7.tkr6xdv7 > div.rq0escxv.l9j0dhe7.du4w35lb > div > div.iqfcb0g7.tojvnm2t.a6sixzi8.k5wvi7nf.q3lfd5jv.pk4s997a.bipmatt0.cebpdrjk.qowsmv63.owwhemhu.dp1hu0rb.dhp61c6y.l9j0dhe7.iyyx5f41.a8s20v7p > div > div > div > form > div > div.kr520xx4.pedkr2u6.ms05siws.pnx7fd3z.b7h9ocf4.pmk7jnqg.j9ispegn > div > div.j83agx80.cbu4d94t.f0kvp8a6.mfofr4af.l9j0dhe7.oh7imozk > div.ihqw7lf3.discj3wi.l9j0dhe7 > div.scb9dxdr.sj5x9vvc.dflh9lhu.cxgpxx05.dhix69tm.wkznzc2l.i1fnvgqd.j83agx80.rq0escxv.ibutc8p7.l82x9zwi.uo3d90p7.pw54ja7n.ue3kfks5.tr4kgdav.eip75gnj.ccnbzhu1.dwg5866k.cwj9ozl2.bp9cbjyn > div:nth-child(2) > div > div:nth-child(2) > span > div";
                arguments.By.Value = "cssselector";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);

                Scripter.Variables.SetVariableValue(arguments.Result.Value, new TextStructure(arguments.Video.Value));
            }
        }
    }
}