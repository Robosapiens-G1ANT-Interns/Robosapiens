using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using G1ANT.Language;


namespace G1ANT.Addon.Facebook
{
    [Command(Name = "facebook.acceptpendingrequest", Tooltip = "This command accepts pending friend requests.")]
    public class FacebookAcceptPendingRequestCommand : Language.Command
    {
        public class Arguments : SeleniumCommandArguments
        {
            [Argument(Name = "Number of requests to accepts", Required = true, Tooltip = "Enter the amount of requests you want to accept.")]
            public IntegerStructure Number { get; set; }

            [Argument(DefaultVariable = "timeoutselenium", Tooltip = "Specifies time in milliseconds for G1ANT.Robot to wait for the command to be executed")]
            public override TimeSpanStructure Timeout { get; set; } = new TimeSpanStructure(SeleniumSettings.SeleniumTimeout);

            [Argument(Tooltip = "By default, waits until the webpage fully loads")]
            public BooleanStructure NoWait { get; set; } = new BooleanStructure(true);

            [Argument(Tooltip = "Result variable")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public FacebookAcceptPendingRequestCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            for (int i = 1; i <= arguments.Number.Value; i++)
            {
                SeleniumManager.CurrentWrapper.Navigate("www.facebook.com", arguments.Timeout.Value, arguments.NoWait.Value);

                arguments.Search.Value = "#mount_0_0 > div > div:nth-child(1) > div.rq0escxv.l9j0dhe7.du4w35lb > div.rq0escxv.l9j0dhe7.du4w35lb > div > div > div.j83agx80.cbu4d94t.d6urw2fd.dp1hu0rb.l9j0dhe7.du4w35lb > div.rq0escxv.l9j0dhe7.du4w35lb.j83agx80.pfnyh3mw.taijpn5t.gs1a9yip.owycx6da.btwxx1t3.dp1hu0rb.p01isnhg > div > div.rq0escxv.lpgh02oy.du4w35lb.pad24vr5.rirtxc74.dp1hu0rb.fer614ym.bx45vsiw.o387gat7.qbu88020.ni8dbmo4.stjgntxs.czl6b2yu > div > div > div.j83agx80.cbu4d94t.buofh1pr > div > div > div.buofh1pr > div:nth-child(2) > ul > li:nth-child(3)";
                arguments.By.Value = "cssselector";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);

                arguments.Search.Value = "#mount_0_0 > div > div:nth-child(1) > div.rq0escxv.l9j0dhe7.du4w35lb > div.rq0escxv.l9j0dhe7.du4w35lb > div > div > div.j83agx80.cbu4d94t.d6urw2fd.dp1hu0rb.l9j0dhe7.du4w35lb > div.rq0escxv.l9j0dhe7.du4w35lb.j83agx80.pfnyh3mw.jifvfom9.gs1a9yip.owycx6da.btwxx1t3.buofh1pr.dp1hu0rb.ka73uehy > div.rq0escxv.l9j0dhe7.tkr6xdv7.j83agx80.cbu4d94t.d2edcug0.pfnyh3mw.dp1hu0rb.rek2kq2y.o36gj0jk > div > div.q5bimw55.rpm2j7zs.k7i0oixp.gvuykj2m.j83agx80.cbu4d94t.ni8dbmo4.eg9m0zos.l9j0dhe7.du4w35lb.ofs802cu.pohlnb88.dkue75c7.mb9wzai9.d8ncny3e.buofh1pr.g5gj957u.tgvbjcpo.l56l04vs.r57mb794.kh7kg01d.c3g1iek1.k4xni2cv > div.j83agx80.cbu4d94t.buofh1pr > div.aov4n071 > div > div:nth-child(3) > div:nth-child(1) > div > a > div.ow4ym5g4.auili1gw.rq0escxv.j83agx80.buofh1pr.g5gj957u.i1fnvgqd.oygrvhab.cxmmr5t8.hcukyx3x.kvgmc6g5.nnctdnn4.hpfvmrgz.qt6c0cv9.jb3vyjys.l9j0dhe7.du4w35lb.bp9cbjyn.btwxx1t3.dflh9lhu.scb9dxdr > div.ow4ym5g4.auili1gw.rq0escxv.j83agx80.buofh1pr.g5gj957u.i1fnvgqd.oygrvhab.cxmmr5t8.hcukyx3x.kvgmc6g5.tgvbjcpo.hpfvmrgz.qt6c0cv9.rz4wbd8a.a8nywdso.jb3vyjys.du4w35lb.bp9cbjyn.btwxx1t3.l9j0dhe7 > div > div.j83agx80.cbu4d94t.a9txdygg.fnu23jab.buofh1pr.iuny7tx3.ipjc6fyt > div > div > div:nth-child(1) > div.oajrlxb2.s1i5eluu.gcieejh5.bn081pho.humdl8nn.izx4hr6d.rq0escxv.nhd2j8a9.j83agx80.p7hjln8o.kvgmc6g5.cxmmr5t8.oygrvhab.hcukyx3x.jb3vyjys.d1544ag0.qt6c0cv9.tw6a2znq.i1ao9s8h.esuyzwwr.f1sip0of.lzcic4wl.l9j0dhe7.abiwlrkh.p8dawk7l.beltcj47.p86d2i9g.aot14ch1.kzx2olss.cbu4d94t.taijpn5t.ni8dbmo4.stjgntxs.k4urcfbm.tv7at329";
                arguments.By.Value = "cssselector";
                SeleniumManager.CurrentWrapper.Click(arguments, arguments.Timeout.Value, waitForNewWindow: false);
            }
            
        }
    }
}