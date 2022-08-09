using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoEditor
{
    public partial class compiling : Form
    {
        public compiling()
        {
            InitializeComponent();

        }

        private void compiling_Load(object sender, EventArgs e)
        {
            this.Activated += AfterLoading;
        }

        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;
            string StorageDirectory = Directory.GetCurrentDirectory() + "\\common\\storage\\";
            bool isAddLeadersExits = File.Exists(StorageDirectory + "addLeaders.editor");
            bool isRemoveAdminsExits = File.Exists(StorageDirectory + "removeAdmins.editor");
            bool isRemoveLeadersExits = File.Exists(StorageDirectory + "removeLeaders.editor");
            bool isRemoveSupportsExits = File.Exists(StorageDirectory + "removeSupports.editor");
            bool isTransferLeadersExits = File.Exists(StorageDirectory + "transferLeaders.editor");
            bool isTransferSupportsExits = File.Exists(StorageDirectory + "transferSupports.editor");
            bool isVostAdminsExits = File.Exists(StorageDirectory + "vostAdmins.editor");
            bool isInviteSupportsExits = File.Exists(StorageDirectory + "inviteSupports.editor");

            if (isAddLeadersExits || isRemoveLeadersExits || isTransferLeadersExits)
                Global.leadersPart1 = "[ Изменения в лидерском составе: ] \n";

            if (isAddLeadersExits)
            {
                status.Text = "ОБРАБОТКА ФАЙЛА НАЗНАЧЕНИЯ ЛИДЕРОВ";
                string[] addLeadersALL = File.ReadAllLines(StorageDirectory + "addLeaders.editor");
                StringBuilder addLeaders = new StringBuilder();
                foreach (string addleader in addLeadersALL)
                {
                    string[] parts = addleader.Split('|');
                    addLeaders.AppendLine($"На пост лидера организации {parts[1]} был назначен {parts[0]}");
                    Global.leadersPart2 = addLeaders.ToString();
                }
            }

            Thread.Sleep(500);

            if (isRemoveLeadersExits)
            {
                status.Text = "ОБРАБОТКА ФАЙЛА СНЯТИЯ ЛИДЕРОВ";
                string[] removeLeadersALL = File.ReadAllLines(StorageDirectory + "removeLeaders.editor");
                StringBuilder removeLeaders = new StringBuilder();
                foreach (string removeLeader in removeLeadersALL)
                {
                    string[] parts = removeLeader.Split('|');
                    removeLeaders.AppendLine($"С поста лидера организации {parts[1]} был снят {parts[0]}");
                    removeLeaders.AppendLine($"Причина: {parts[2]}");
                    Global.leadersPart3 = removeLeaders.ToString();
                }
            }

            Thread.Sleep(500);

            if (isTransferLeadersExits)
            {
                status.Text = "ОБРАБОТКА ФАЙЛА ПЕРЕВОДА ЛИДЕРОВ";
                string[] transferLeadersALL = File.ReadAllLines(StorageDirectory + "transferLeaders.editor");
                StringBuilder transferLeaders = new StringBuilder();
                foreach (string transferLeader in transferLeadersALL)
                {
                    string[] parts = transferLeader.Split('|');
                    transferLeaders.AppendLine($"Лидер организации {parts[1]} {parts[0]} успешно отстоял срок и был переведен на пост администратора 1-го уровня");
                    Global.leadersPart4 = transferLeaders.ToString();
                }
            }

            if (isVostAdminsExits || isRemoveAdminsExits)
                Global.adminsPart1 = "[ Изменения в составе администрации: ] \n";

            Thread.Sleep(500);

            if (isVostAdminsExits)
            {
                status.Text = "ОБРАБОТКА ФАЙЛА ВОССТАНОВЛЕНИЙ АДМИНИСТРАЦИИ";
                string[] vostAdminsALL = File.ReadAllLines(StorageDirectory + "vostAdmins.editor");
                StringBuilder vostAdmins = new StringBuilder();
                foreach (string vostAdmin in vostAdminsALL)
                {
                    string[] parts = vostAdmin.Split('|');
                    vostAdmins.AppendLine($"На пост администратора {parts[1]} уровня был восстановлен {parts[0]}");
                    Global.adminsPart2 = vostAdmins.ToString();
                }
            }

            Thread.Sleep(500);

            if (isRemoveAdminsExits)
            {
                status.Text = "ОБРАБОТКА ФАЙЛА СНЯТИЙ АДМИНИСТРАЦИИ";
                string[] removeAdminsALL = File.ReadAllLines(StorageDirectory + "removeAdmins.editor");
                StringBuilder removeAdmins = new StringBuilder();
                foreach (string removeAdmin in removeAdminsALL)
                {
                    string[] parts = removeAdmin.Split('|');
                    removeAdmins.AppendLine($"С поста администратора {parts[1]} уровня был снят {parts[0]}");
                    removeAdmins.AppendLine($"Причина: {parts[2]}");
                    Global.adminsPart3 = removeAdmins.ToString();
                }
            }

            if (isInviteSupportsExits || isTransferSupportsExits || isRemoveSupportsExits)
                Global.supportsPart1 = "[ Изменения в составе игровых помощников: ] \n";

            Thread.Sleep(500);

            if (isInviteSupportsExits)
            {
                status.Text = "ОБРАБОТКА ФАЙЛА НАЗНАЧЕНИЙ ИГРОВЫХ ПОМОЩНИКОВ";
                string[] inviteSupportsALL = File.ReadAllLines(StorageDirectory + "inviteSupports.editor");
                StringBuilder inviteSupports = new StringBuilder();
                foreach (string inviteSupport in inviteSupportsALL)
                {
                    string[] parts = inviteSupport.Split('|');
                    inviteSupports.AppendLine($"На пост игрового помощника назначен {parts[0]}");
                    Global.supportsPart2 = inviteSupports.ToString();
                }
            }

            Thread.Sleep(500);

            if (isTransferSupportsExits)
            {
                status.Text = "ОБРАБОТКА ФАЙЛА ПЕРЕВОДОВ ИГРОВЫХ ПОМОЩНИКОВ";
                string[] transferSupportsALL = File.ReadAllLines(StorageDirectory + "transferSupports.editor");
                StringBuilder transferSupports = new StringBuilder();
                foreach (string transferSupport in transferSupportsALL)
                {
                    string[] parts = transferSupport.Split('|');
                    transferSupports.AppendLine($"Игровой помощник {parts[0]} отстоял срок и переведен на пост администратора 1-го уровня");
                    Global.supportsPart3 = transferSupports.ToString();
                }
            }

            Thread.Sleep(500);

            if (isRemoveSupportsExits)
            {
                status.Text = "ОБРАБОТКА ФАЙЛА СНЯТЫЙ ИГРОВЫХ ПОМОЩНИКОВ";
                string[] removeSupportsALL = File.ReadAllLines(StorageDirectory + "removeSupports.editor");
                StringBuilder removeSupports = new StringBuilder();
                foreach (string removeSupport in removeSupportsALL)
                {
                    string[] parts = removeSupport.Split('|');
                    removeSupports.AppendLine($"С поста игрового помощника был снят {parts[0]}");
                    removeSupports.AppendLine($"Причина: {parts[1]}");
                    Global.supportsPart4 = removeSupports.ToString();
                }
            }

            status.Text = "ОБРАБОТКА ФАЙЛОВ УСПЕШНО ЗАВЕРШЕНА, НАЧИНАЕТСЯ ПРОЦЕСС КОМПИЛЯЦИИ ДАННЫХ В ТЕКСТ...";

            Thread.Sleep(1500);

            StringBuilder compiling = new StringBuilder();

            // Интро
            compiling.AppendLine($"📅Новости за {DateTime.Today.Day}.{DateTime.Today.Month}.{DateTime.Today.Year}📅");
            compiling.AppendLine();
            compiling.AppendLine("#information03");
            compiling.AppendLine();
            // Лидеры
            if (isAddLeadersExits || isTransferLeadersExits || isRemoveLeadersExits)
                compiling.AppendLine(Global.leadersPart1);
            if (isAddLeadersExits)
                compiling.AppendLine(Global.leadersPart2);
            if (isRemoveLeadersExits)
                compiling.AppendLine(Global.leadersPart3);
            if (isTransferLeadersExits)
                compiling.AppendLine(Global.leadersPart4);
            // Админы
            if (isVostAdminsExits || isRemoveAdminsExits)
                compiling.AppendLine(Global.adminsPart1);
            if (isVostAdminsExits)
                compiling.AppendLine(Global.adminsPart2);
            if (isRemoveAdminsExits)
                compiling.AppendLine(Global.adminsPart3);
            // Саппорты
            if (isInviteSupportsExits || isTransferSupportsExits || isRemoveSupportsExits)
                compiling.AppendLine(Global.supportsPart1);
            if (isInviteSupportsExits)
                compiling.AppendLine(Global.supportsPart2);
            if (isTransferSupportsExits)
                compiling.AppendLine(Global.supportsPart3);
            if (isRemoveSupportsExits)
                compiling.AppendLine(Global.supportsPart4);
            // Аутро
            compiling.AppendLine();
            compiling.AppendLine("___________________________________________________________________________");
            compiling.AppendLine("Присоединяйся к Матрёшке RP прямо сейчас!");
            compiling.AppendLine("Наш Discord: https://discord.gg/GWtU7PHPDp");
            compiling.AppendLine("Скачать игру: https://matrp.ru/play");

            status.Text = "КОМПИЛЯЦИЯ УСПЕШНО ЗАВЕРШЕНА, НАЧИНАЕТСЯ ПРОЦЕСС СОХРАНЕНИЯ ИНФОРМАЦИИ...";

            Thread.Sleep(1500);

            // Сохранение полученных данных
            compiledText.Text = compiling.ToString();
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\common\\storage\\result.txt", compiling.ToString());

            status.Text = $"СОХРАНЕНИЕ ДАННЫХ УСПЕШНО ПРОИЗОШЛО. СКОПИРУЙТЕ ГОТОВЫЙ ТЕКСТ НИЖЕ ИЛИ ОТКРОЙТЕ ПО ПУТИ: {Directory.GetCurrentDirectory()}\\common\\storage\\result.txt";
        }

        private void compiling_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] files = { "addLeaders.editor", "inviteSupports.editor", "removeAdmins.editor", "removeLeaders.editor", "removeSupports.editor", "transferLeaders.editor", "transferSupports.editor", "vostAdmins.editor" };
            try
            {
                foreach (string file in files)
                {
                    File.Delete(Directory.GetCurrentDirectory() + "\\common\\storage\\" + file);
                }
            }
            catch (IOException) 
            { 
                
            }

            Application.Exit();
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
