// Decompiled with JetBrains decompiler
// Type: UnityEngine.AudioSource
// Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 41C3F0DB-5B29-4EE7-952C-69A689436367
// Assembly location: D:\unity\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
  /// <summary>
  ///   <para>A representation of audio sources in 3D.</para>
  /// </summary>
  [RequireComponent(typeof (Transform))]
  [StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
  public sealed class AudioSource : AudioBehaviour
  {
    /// <summary>
    ///   <para>PanLevel has been deprecated. Use spatialBlend instead.</para>
    /// </summary>
    [Obsolete("AudioSource.panLevel has been deprecated. Use AudioSource.spatialBlend instead (UnityUpgradable) -> spatialBlend", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public float panLevel
    {
      get => this.spatialBlend;
      set
      {
      }
    }

    /// <summary>
    ///   <para>Pan has been deprecated. Use panStereo instead.</para>
    /// </summary>
    [Obsolete("AudioSource.pan has been deprecated. Use AudioSource.panStereo instead (UnityUpgradable) -> panStereo", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public float pan
    {
      get => this.panStereo;
      set
      {
      }
    }

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern float GetPitch([NotNull] AudioSource source);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetPitch([NotNull] AudioSource source, float pitch);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void PlayHelper([NotNull] AudioSource source, ulong delay);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Play(double delay);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void PlayOneShotHelper(
      [NotNull] AudioSource source,
      AudioClip clip,
      float volumeScale);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern void Stop(bool stopOneShots);

    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void SetCustomCurveHelper(
      [NotNull] AudioSource source,
      AudioSourceCurveType type,
      AnimationCurve curve);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern AnimationCurve GetCustomCurveHelper(
      [NotNull] AudioSource source,
      AudioSourceCurveType type);

    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetOutputDataHelper(
      [NotNull] AudioSource source,
      [Out] float[] samples,
      int channel);

    [NativeThrows]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void GetSpectrumDataHelper(
      [NotNull] AudioSource source,
      [Out] float[] samples,
      int channel,
      FFTWindow window);

    /// <summary>
    ///   <para>The volume of the audio source (0.0 to 1.0).</para>
    /// </summary>
    public extern float volume { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The pitch of the audio source.</para>
    /// </summary>
    public float pitch
    {
      get => AudioSource.GetPitch(this);
      set => AudioSource.SetPitch(this, value);
    }

    /// <summary>
    ///   <para>Playback position in seconds.</para>
    /// </summary>
    [NativeProperty("SecPosition")]
    public extern float time { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Playback position in PCM samples.</para>
    /// </summary>
    [NativeProperty("SamplePosition")]
    public extern int timeSamples { [NativeMethod(IsThreadSafe = true), MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod(IsThreadSafe = true), MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The default AudioClip to play.</para>
    /// </summary>
    [NativeProperty("AudioClip")]
    public extern AudioClip clip { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>The target group to which the AudioSource should route its signal.</para>
    /// </summary>
    public extern AudioMixerGroup outputAudioMixerGroup { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    [ExcludeFromDocs]
    public void Play() => AudioSource.PlayHelper(this, 0UL);

    /// <summary>
    ///   <para>Plays the clip.</para>
    /// </summary>
    /// <param name="delay">Deprecated. Delay in number of samples, assuming a 44100Hz sample rate (meaning that Play(44100) will delay the playing by exactly 1 sec).</param>
    public void Play([DefaultValue("0")] ulong delay) => AudioSource.PlayHelper(this, delay);

    /// <summary>
    ///   <para>Plays the clip with a delay specified in seconds. Users are advised to use this function instead of the old Play(delay) function that took a delay specified in samples relative to a reference rate of 44.1 kHz as an argument.</para>
    /// </summary>
    /// <param name="delay">Delay time specified in seconds.</param>
    public void PlayDelayed(float delay) => this.Play((double) delay < 0.0 ? 0.0 : -(double) delay);

    /// <summary>
    ///   <para>Plays the clip at a specific time on the absolute time-line that AudioSettings.dspTime reads from.</para>
    /// </summary>
    /// <param name="time">Time in seconds on the absolute time-line that AudioSettings.dspTime refers to for when the sound should start playing.</param>
    public void PlayScheduled(double time) => this.Play(time < 0.0 ? 0.0 : time);

    /// <summary>
    ///   <para>Plays an AudioClip, and scales the AudioSource volume by volumeScale.</para>
    /// </summary>
    /// <param name="clip">The clip being played.</param>
    /// <param name="volumeScale">The scale of the volume (0-1).</param>
    [ExcludeFromDocs]
    public void PlayOneShot(AudioClip clip) => this.PlayOneShot(clip, 1f);

    /// <summary>
    ///   <para>Plays an AudioClip, and scales the AudioSource volume by volumeScale.</para>
    /// </summary>
    /// <param name="clip">The clip being played.</param>
    /// <param name="volumeScale">The scale of the volume (0-1).</param>
    public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale)
    {
      if ((Object) clip == (Object) null)
        Debug.LogWarning((object) "PlayOneShot was called with a null AudioClip.");
      else
        AudioSource.PlayOneShotHelper(this, clip, volumeScale);
    }

    /// <summary>
    ///   <para>Changes the time at which a sound that has already been scheduled to play will start.</para>
    /// </summary>
    /// <param name="time">Time in seconds.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetScheduledStartTime(double time);

    /// <summary>
    ///   <para>Changes the time at which a sound that has already been scheduled to play will end. Notice that depending on the timing not all rescheduling requests can be fulfilled.</para>
    /// </summary>
    /// <param name="time">Time in seconds.</param>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void SetScheduledEndTime(double time);

    /// <summary>
    ///   <para>Stops playing the clip.</para>
    /// </summary>
    public void Stop() => this.Stop(true);

    /// <summary>
    ///   <para>Pauses playing the clip.</para>
    /// </summary>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void Pause();

    /// <summary>
    ///   <para>Unpause the paused playback of this AudioSource.</para>
    /// </summary>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern void UnPause();

    /// <summary>
    ///   <para>Is the clip playing right now (Read Only)?</para>
    /// </summary>
    public extern bool isPlaying { [NativeName("IsPlayingScripting"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>True if all sounds played by the AudioSource (main sound started by Play() or playOnAwake as well as one-shots) are culled by the audio system.</para>
    /// </summary>
    public extern bool isVirtual { [NativeName("GetLastVirtualState"), MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Plays an AudioClip at a given position in world space.</para>
    /// </summary>
    /// <param name="clip">Audio data to play.</param>
    /// <param name="position">Position in world space from which sound originates.</param>
    /// <param name="volume">Playback volume.</param>
    [ExcludeFromDocs]
    public static void PlayClipAtPoint(AudioClip clip, Vector3 position) => AudioSource.PlayClipAtPoint(clip, position, 1f);

    /// <summary>
    ///   <para>Plays an AudioClip at a given position in world space.</para>
    /// </summary>
    /// <param name="clip">Audio data to play.</param>
    /// <param name="position">Position in world space from which sound originates.</param>
    /// <param name="volume">Playback volume.</param>
    public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume)
    {
      GameObject gameObject = new GameObject("One shot audio");
      gameObject.transform.position = position;
      AudioSource audioSource = (AudioSource) gameObject.AddComponent(typeof (AudioSource));
      audioSource.clip = clip;
      audioSource.spatialBlend = 1f;
      audioSource.volume = volume;
      audioSource.Play();
      Object.Destroy((Object) gameObject, clip.length * ((double) Time.timeScale < 0.00999999977648258 ? 0.01f : Time.timeScale));
    }

    /// <summary>
    ///   <para>Is the audio clip looping?</para>
    /// </summary>
    public extern bool loop { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>This makes the audio source not take into account the volume of the audio listener.</para>
    /// </summary>
    public extern bool ignoreListenerVolume { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>If set to true, the audio source will automatically start playing on awake.</para>
    /// </summary>
    public extern bool playOnAwake { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Allows AudioSource to play even though AudioListener.pause is set to true. This is useful for the menu element sounds or background music in pause menus.</para>
    /// </summary>
    public extern bool ignoreListenerPause { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Whether the Audio Source should be updated in the fixed or dynamic update.</para>
    /// </summary>
    public extern AudioVelocityUpdateMode velocityUpdateMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Pans a playing sound in a stereo way (left or right). This only applies to sounds that are Mono or Stereo.</para>
    /// </summary>
    [NativeProperty("StereoPan")]
    public extern float panStereo { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Sets how much this AudioSource is affected by 3D spatialisation calculations (attenuation, doppler etc). 0.0 makes the sound full 2D, 1.0 makes it full 3D.</para>
    /// </summary>
    [NativeProperty("SpatialBlendMix")]
    public extern float spatialBlend { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Enables or disables spatialization.</para>
    /// </summary>
    public extern bool spatialize { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Determines if the spatializer effect is inserted before or after the effect filters.</para>
    /// </summary>
    public extern bool spatializePostEffects { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Set the custom curve for the given AudioSourceCurveType.</para>
    /// </summary>
    /// <param name="type">The curve type that should be set.</param>
    /// <param name="curve">The curve that should be applied to the given curve type.</param>
    public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) => AudioSource.SetCustomCurveHelper(this, type, curve);

    /// <summary>
    ///   <para>Get the current custom curve for the given AudioSourceCurveType.</para>
    /// </summary>
    /// <param name="type">The curve type to get.</param>
    /// <returns>
    ///   <para>The custom AnimationCurve corresponding to the given curve type.</para>
    /// </returns>
    public AnimationCurve GetCustomCurve(AudioSourceCurveType type) => AudioSource.GetCustomCurveHelper(this, type);

    /// <summary>
    ///   <para>The amount by which the signal from the AudioSource will be mixed into the global reverb associated with the Reverb Zones.</para>
    /// </summary>
    public extern float reverbZoneMix { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Bypass effects (Applied from filter components or global listener filters).</para>
    /// </summary>
    public extern bool bypassEffects { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>When set global effects on the AudioListener will not be applied to the audio signal generated by the AudioSource. Does not apply if the AudioSource is playing into a mixer group.</para>
    /// </summary>
    public extern bool bypassListenerEffects { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>When set doesn't route the signal from an AudioSource into the global reverb associated with reverb zones.</para>
    /// </summary>
    public extern bool bypassReverbZones { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Sets the Doppler scale for this AudioSource.</para>
    /// </summary>
    public extern float dopplerLevel { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Sets the spread angle (in degrees) of a 3d stereo or multichannel sound in speaker space.</para>
    /// </summary>
    public extern float spread { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Sets the priority of the AudioSource.</para>
    /// </summary>
    public extern int priority { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Un- / Mutes the AudioSource. Mute sets the volume=0, Un-Mute restore the original volume.</para>
    /// </summary>
    public extern bool mute { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Within the Min distance the AudioSource will cease to grow louder in volume.</para>
    /// </summary>
    public extern float minDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>(Logarithmic rolloff) MaxDistance is the distance a sound stops attenuating at.</para>
    /// </summary>
    public extern float maxDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Sets/Gets how the AudioSource attenuates over distance.</para>
    /// </summary>
    public extern AudioRolloffMode rolloffMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Deprecated Version. Returns a block of the currently playing source's output data.</para>
    /// </summary>
    /// <param name="numSamples"></param>
    /// <param name="channel"></param>
    [Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
    public float[] GetOutputData(int numSamples, int channel)
    {
      float[] samples = new float[numSamples];
      AudioSource.GetOutputDataHelper(this, samples, channel);
      return samples;
    }

    /// <summary>
    ///   <para>Provides a block of the currently playing source's output data.</para>
    /// </summary>
    /// <param name="samples">The array to populate with audio samples. Its length must be a power of 2.</param>
    /// <param name="channel">The channel to sample from.</param>
    public void GetOutputData(float[] samples, int channel) => AudioSource.GetOutputDataHelper(this, samples, channel);

    /// <summary>
    ///   <para>Deprecated Version. Returns a block of the currently playing source's spectrum data.</para>
    /// </summary>
    /// <param name="numSamples">The number of samples to retrieve. Must be a power of 2.</param>
    /// <param name="channel">The channel to sample from.</param>
    /// <param name="window">The FFTWindow type to use when sampling.</param>
    [Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
    public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window)
    {
      float[] samples = new float[numSamples];
      AudioSource.GetSpectrumDataHelper(this, samples, channel, window);
      return samples;
    }

    /// <summary>
    ///   <para>Provides a block of the currently playing audio source's spectrum data.</para>
    /// </summary>
    /// <param name="samples">The array to populate with audio samples. Its length must be a power of 2.</param>
    /// <param name="channel">The channel to sample from.</param>
    /// <param name="window">The FFTWindow type to use when sampling.</param>
    public void GetSpectrumData(float[] samples, int channel, FFTWindow window) => AudioSource.GetSpectrumDataHelper(this, samples, channel, window);

    [Obsolete("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
    public float minVolume
    {
      get
      {
        Debug.LogError((object) "minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
        return 0.0f;
      }
      set => Debug.LogError((object) "minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
    }

    [Obsolete("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
    public float maxVolume
    {
      get
      {
        Debug.LogError((object) "maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
        return 0.0f;
      }
      set => Debug.LogError((object) "maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
    }

    [Obsolete("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
    public float rolloffFactor
    {
      get
      {
        Debug.LogError((object) "rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
        return 0.0f;
      }
      set => Debug.LogError((object) "rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
    }

    /// <summary>
    ///   <para>Sets a user-defined parameter of a custom spatializer effect that is attached to an AudioSource.</para>
    /// </summary>
    /// <param name="index">Zero-based index of user-defined parameter to be set.</param>
    /// <param name="value">New value of the user-defined parameter.</param>
    /// <returns>
    ///   <para>True, if the parameter could be set.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool SetSpatializerFloat(int index, float value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool GetSpatializerFloat(int index, out float value);

    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool GetAmbisonicDecoderFloat(int index, out float value);

    /// <summary>
    ///   <para>Sets a user-defined parameter of a custom ambisonic decoder effect that is attached to an AudioSource.</para>
    /// </summary>
    /// <param name="index">Zero-based index of user-defined parameter to be set.</param>
    /// <param name="value">New value of the user-defined parameter.</param>
    /// <returns>
    ///   <para>True, if the parameter could be set.</para>
    /// </returns>
    [MethodImpl(MethodImplOptions.InternalCall)]
    public extern bool SetAmbisonicDecoderFloat(int index, float value);
  }
}
