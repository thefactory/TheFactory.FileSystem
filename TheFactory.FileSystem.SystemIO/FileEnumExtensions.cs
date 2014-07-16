using System;

using IOFileMode = System.IO.FileMode;
using IOFileAccess = System.IO.FileAccess;
using IOFileShare = System.IO.FileShare;
using TheFactory.FileSystem;

namespace TheFactory.FileSystem.SystemIO {
    public static class FileEnumExtensions {
        public static IOFileMode ToIO(this FileMode This) {
            switch (This) {
                case FileMode.Open:
                    return IOFileMode.Open;
                case FileMode.Create:
                    return IOFileMode.Create;
                case FileMode.Append:
                    return IOFileMode.Append;
                case FileMode.OpenOrCreate:
                    return IOFileMode.OpenOrCreate;
            }

            throw new InvalidOperationException(String.Format("Unknown FileMode {0}", This));
        }

        public static IOFileAccess ToIO(this FileAccess This) {
            switch (This) {
                case FileAccess.Read:
                    return IOFileAccess.Read;
                case FileAccess.Write:
                    return IOFileAccess.Write;
            }

            throw new InvalidOperationException(String.Format("Unknown FileAccess {0}", This));
        }

        public static IOFileShare ToIO(this FileShare This) {
            switch (This) {
                case FileShare.None:
                    return IOFileShare.None;
                case FileShare.Read:
                    return IOFileShare.Read;
            }

            throw new InvalidOperationException(String.Format("Unknown FileShare {0}", This));
        }
    }
}

