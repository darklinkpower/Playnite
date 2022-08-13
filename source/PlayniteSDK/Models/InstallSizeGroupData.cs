using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite.SDK.Models
{
    /// <summary>
    /// Represents install size grouping element
    /// </summary>
    public class InstallSizeGroupData : ObservableObject
    {
        private ulong maxSizeBytes;
        /// <summary>
        /// Gets or sets size in bytes
        /// </summary>
        public ulong MaxSizeBytes
        {
            get => maxSizeBytes;
            set
            {
                maxSizeBytes = value;
                OnPropertyChanged();
            }
        }

        private string maxSizeReadable;
        /// <summary>
        /// Gets or sets size in readable format
        /// </summary>
        public string MaxSizeReadable
        {
            get => maxSizeReadable;
            set
            {
                maxSizeReadable = value;
                OnPropertyChanged();
            }
        }
    }
}