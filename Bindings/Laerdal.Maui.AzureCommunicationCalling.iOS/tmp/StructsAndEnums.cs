using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Laerdal.Maui.AzureCommunicationCalling.iOS
{
	[StructLayout (LayoutKind.Sequential)]
	public struct ACSStreamSize
	{
		public int width;

		public int height;
	}

	[Flags]
	[Native]
	public enum ACSCallingCommunicationErrors : long
	{
		None = 0x0,
		NoAudioPermission = 0x1,
		NoVideoPermission = 0x2,
		NoAudioAndVideoPermission = 0x3,
		ReceivedInvalidPushNotificationPayload = 0x4,
		FailedToProcessPushNotificationPayload = 0x8,
		InvalidGuidGroupId = 0x10,
		InvalidPushNotificationDeviceRegistrationToken = 0x20,
		MultipleRenderersNotSupported = 0x40,
		MultipleViewsNotSupported = 0x80,
		InvalidLocalVideoStreamForVideoOptions = 0x100,
		NoMultipleConnectionsWithSameIdentity = 0x200,
		InvalidServerCallId = 0x400,
		LocalVideoStreamSwitchSourceFailure = 0x800,
		IncomingCallAlreadyUnplaced = 0x1000,
		InvalidMeetingLink = 0x4000,
		ParticipantAddedToUnconnectedCall = 0x8000,
		ParticipantAlreadyAddedToCall = 0x10000,
		CallFeatureExtensionNotFound = 0x20000,
		DisplayNameLengthLongerThanSupported = 0x800000,
		FailedToHangupForEveryone = 0x1000000,
		InvalidParticipantAddedToCall = 0x20000000,
		FeatureExtensionNotFound = 0x8000000,
		VideoEffectNotSupported = 0x10000000,
		FailedToSendRawAudioBuffer = 0x5,
		CannotMuteVirtualAudioStream = 0x6,
		DuplicateDeviceId = 0x40000,
		DelegateIsRequired = 0x80000,
		VirtualDeviceNotStarted = 0x100000,
		InvalidVideoStreamCombination = 0x400000,
		NoMultipleConnectionsWithDifferentClouds = 0x2000000,
		NoActiveAudioStreamToStop = 0x4000000,
		InvalidVideoFormat = 0x101,
		InvalidBuffer = 0x102,
		RawVideoFrameNotSent = 0x103,
		UnsupportedVideoStreamResolution = 0x104,
		CaptionsFailedToStart = 0x105,
		CaptionsDisabledByConfigurations = 0x106,
		CaptionsPolicyDisabled = 0x107,
		CaptionsNotActive = 0x108,
		CaptionsRequestedLanguageNotSupported = 0x109,
		FailedToSetCaptionLanguage = 0x10a,
		SetCaptionLanguageDisabled = 0x10b,
		SetCaptionLanguageTeamsPremiumLicenseNeeded = 0x10c,
		CaptionsFailedToSetSpokenLanguage = 0x10d,
		CaptionsSetSpokenLanguageDisabled = 0x10e,
		GetCaptionsFailedCallStateNotConnected = 0x10f,
		GetCaptionsFailed = 0x110,
		SpotlightDisabledByConfigurations = 0x111,
		MaxSpotlightReached = 0x112,
		SpotlightParticipantEmptyList = 0x113,
		SignalingOperationFailed = 0x114,
		ProxyNotAvailableForTeams = 0x115,
		MuteOthersForbidden = 0x116,
		MuteOthersInternalServerError = 0x117,
		MuteOthersNotFound = 0x118,
		LobbyDisabledByConfigurations = 0x119,
		LobbyConversationTypeNotSupported = 0x11a,
		LobbyMeetingRoleNotAllowed = 0x11b,
		LobbyParticipantNotExist = 0x11c,
		RemoveParticipantOperationFailure = 0x11d,
		MusicModeNotEnabled = 0x11e,
		SurveyRatingScaleOutOfBounds = 0x11f,
		SurveyRatingScaleInvalidThreshold = 0x120,
		SurveyScoreOutOfBounds = 0x121,
		SurveyDoubleSubmissionNotAllowed = 0x122,
		LobbyAdmitOperationFailure = 0x123
	}

	[Native]
	public enum ACSVideoStreamType : long
	{
		RemoteIncoming = 1,
		RawIncoming = 2,
		LocalOutgoing = 3,
		VirtualOutgoing = 4,
		ScreenShareOutgoing = 5
	}

	[Native]
	public enum ACSVideoStreamSourceType : long
	{
		Video = 1,
		ScreenSharing = 2
	}

	[Native]
	public enum ACSVideoStreamState : long
	{
		Available = 0,
		Started = 1,
		Stopping = 2,
		Stopped = 3,
		NotAvailable = 4
	}

	[Native]
	public enum ACSStreamDirection : long
	{
		Incoming = 0,
		Outgoing = 1
	}

	[Native]
	public enum ACSMediaStreamType : long
	{
		Video = 1,
		ScreenSharing = 2
	}

	[Native]
	public enum ACSCameraFacing : long
	{
		Unknown = 0,
		External = 1,
		Front = 2,
		Back = 3,
		Panoramic = 4,
		LeftFront = 5,
		RightFront = 6
	}

	[Native]
	public enum ACSVideoDeviceType : long
	{
		Unknown = 0,
		UsbCamera = 1,
		CaptureAdapter = 2,
		Virtual = 3
	}

	[Native]
	public enum ACSNoiseSuppressionMode : long
	{
		Off = 0,
		Auto = 1,
		Low = 2,
		High = 3
	}

	[Native]
	public enum ACSPushNotificationEventType : long
	{
		IncomingCall = 107,
		IncomingGroupCall = 109,
		IncomingPstnCall = 111,
		StopRinging = 110
	}

	[Native]
	public enum ACSCallParticipantRole : long
	{
		Uninitialized = 0,
		Attendee = 1,
		Consumer = 2,
		Presenter = 3,
		Organizer = 4,
		CoOrganizer = 5
	}

	[Native]
	public enum ACSParticipantState : long
	{
		Idle = 0,
		EarlyMedia = 1,
		Connecting = 2,
		Connected = 3,
		Hold = 4,
		InLobby = 5,
		Disconnected = 6,
		Ringing = 7
	}

	[Native]
	public enum ACSScalingMode : long
	{
		Crop = 1,
		Fit = 2
	}

	[Native]
	public enum ACSCallState : long
	{
		None = 0,
		EarlyMedia = 1,
		Connecting = 3,
		Ringing = 4,
		Connected = 5,
		LocalHold = 6,
		Disconnecting = 7,
		Disconnected = 8,
		InLobby = 9,
		RemoteHold = 10
	}

	[Native]
	public enum ACSDtmfTone : long
	{
		Zero = 0,
		One = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Star = 10,
		Pound = 11,
		A = 12,
		B = 13,
		C = 14,
		D = 15,
		Flash = 16
	}

	[Native]
	public enum ACSCallDirection : long
	{
		Outgoing = 1,
		Incoming = 2
	}

	[Native]
	public enum ACSRecordingState : long
	{
		Started = 0,
		Paused = 1,
		Ended = 2
	}

	[Native]
	public enum ACSCaptionsResultType : long
	{
		Partial = 0,
		Final = 1
	}

	[Native]
	public enum ACSCaptionsType : long
	{
		TeamsCaptions = 0,
		CommunicationCaptions = 1
	}

	[Native]
	public enum ACSRawVideoFrameType : long
	{
		Buffer = 0,
		Texture = 1
	}

	[Native]
	public enum ACSVideoStreamPixelFormat : long
	{
		Bgrx = 0,
		Bgr24 = 1,
		Rgbx = 2,
		Rgba = 3,
		Nv12 = 4,
		I420 = 5
	}

	[Native]
	public enum ACSVideoStreamResolution : long
	{
		Unknown = 0,
		P1080 = 1,
		P720 = 2,
		P540 = 3,
		P480 = 4,
		P360 = 5,
		P270 = 6,
		P240 = 7,
		P180 = 8,
		FullHd = 9,
		Hd = 10,
		Vga = 11,
		Qvga = 12
	}

	[Native]
	public enum ACSAudioStreamState : long
	{
		arted = 0,
		opped = 1
	}

	[Native]
	public enum ACSAudioStreamSampleRate : long
	{
		ACSAudioStreamSampleRateHz_16000 = 0,
		ACSAudioStreamSampleRateHz_22050 = 1,
		ACSAudioStreamSampleRateHz_24000 = 2,
		ACSAudioStreamSampleRateHz_32000 = 3,
		ACSAudioStreamSampleRateHz_44100 = 4,
		ACSAudioStreamSampleRateHz_48000 = 5
	}

	[Native]
	public enum ACSAudioStreamChannelMode : long
	{
		Mono = 0,
		Stereo = 1
	}

	[Native]
	public enum ACSAudioStreamFormat : long
	{
		ACSAudioStreamFormatPcm16Bit = 0
	}

	[Native]
	public enum ACSAudioStreamBufferDuration : long
	{
		ACSAudioStreamBufferDurationMs10 = 0,
		ACSAudioStreamBufferDurationMs20 = 1
	}

	[Native]
	public enum ACSAudioStreamType : long
	{
		RemoteIncoming = 1,
		RawIncoming = 2,
		LocalOutgoing = 3,
		VirtualOutgoing = 4
	}

	[Native]
	public enum ACSDataChannelPriority : long
	{
		Normal = 0,
		High = 1
	}

	[Native]
	public enum ACSDataChannelReliability : long
	{
		Lossy = 0,
		Durable = 1
	}

	[Native]
	public enum ACSDiagnosticQuality : long
	{
		Unknown = 0,
		Good = 1,
		Poor = 2,
		Bad = 3
	}

	[Flags]
	[Native]
	public enum ACSCallIssues : long
	{
		None = 0x0,
		CannotJoin = 0x1,
		CannotInvite = 0x2,
		HadToRejoin = 0x4,
		EndedUnexpectedly = 0x8,
		OtherIssues = 0x10
	}

	[Flags]
	[Native]
	public enum ACSAudioIssues : long
	{
		None = 0x0,
		NoLocalAudio = 0x1,
		NoRemoteAudio = 0x2,
		Echo = 0x4,
		AudioNoise = 0x8,
		LowVolume = 0x10,
		AudioStoppedUnexpectedly = 0x20,
		DistortedSpeech = 0x40,
		AudioInterruption = 0x80,
		OtherIssues = 0x100
	}

	[Flags]
	[Native]
	public enum ACSVideoIssues : long
	{
		None = 0x0,
		NoVideoReceived = 0x1,
		NoVideoSent = 0x2,
		LowQuality = 0x4,
		Freezes = 0x8,
		StoppedUnexpectedly = 0x10,
		DarkVideoReceived = 0x20,
		AudioVideoOutOfSync = 0x40,
		OtherIssues = 0x80
	}

	[Flags]
	[Native]
	public enum ACSScreenShareIssues : long
	{
		None = 0x0,
		NoContentLocal = 0x1,
		NoContentRemote = 0x2,
		CannotPresent = 0x4,
		LowQuality = 0x8,
		Freezes = 0x10,
		StoppedUnexpectedly = 0x20,
		LargeDelay = 0x40,
		OtherIssues = 0x80
	}

	[Native]
	public enum ACSContentSharingState : long
	{
		arted = 0,
		opped = 1
	}

	[Native]
	public enum ACSContentSharingType : long
	{
		None = 0,
		Powerpoint = 1
	}
}
