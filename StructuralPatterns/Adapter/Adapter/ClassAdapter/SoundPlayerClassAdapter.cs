using System.Media;

namespace Adapter.ClassAdapter
{
    public class SoundPlayerClassAdapter : SoundPlayer, IAudioPlayer
    {
        private bool _isTrackSpecified;

        public void LoadTrack(string fileName)
        {
            SoundLocation = fileName;

            try
            {
                Load();
                _isTrackSpecified = true;
            }
            catch
            {
                _isTrackSpecified = false;
            }
        }

        public void PlayTrack()
        {
            if (_isTrackSpecified)
            {
                Play();
            }
        }
    }
}
