using System;
using System.IO;

namespace TheFactory.FileSystem {
    public interface IFileSystem {
        Stream GetStream(string path, FileMode mode, FileAccess access, FileShare share);

        bool Exists(string path);

        void CreateDirectory(string path);

        IDisposable FileLock(string path);

        void Remove(string path);

        void RemoveDirectory(string path);

        void Move(string fromPath, string toPath);
    }

    public static class IFileSystemExtensions {
        public static Stream GetStream(this IFileSystem This, string path, FileMode mode, FileAccess access) {
            return This.GetStream(path, mode, access, FileShare.Read);
        }
    }

    public enum FileMode {
        Open,
        Create,
        OpenOrCreate,
        Append
    }

    public enum FileAccess {
        Read,
        Write
    }

    public enum FileShare {
        Read,
        None,
    }
}

