using System.Media;

namespace Adapter.ObjectAdapter
{
    public class SoundPlayerObjectAdapter : IAudioPlayer
    {
        // Adaptee object
        private readonly SoundPlayer _player = new SoundPlayer();

        private bool _isTrackSpecified;

        public void LoadTrack(string fileName)
        {
            _player.SoundLocation = fileName;

            try
            {
                _player.Load();
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
                _player.Play();
            }
        }
    }
}
