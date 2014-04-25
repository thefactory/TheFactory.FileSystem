using System;
using System.IO;
using TheFactory.FileSystem;

using IOFileMode = System.IO.FileMode;
using IOFileAccess = System.IO.FileAccess;
using IOFileShare = System.IO.FileShare;

namespace TheFactory.FileSystem.IOS {
    public class IOSFileSystem : IFileSystem {

        public Stream GetStream(string path, FileMode mode, FileAccess access, FileShare share) {
            return new FileStream(path, mode.ToIO(), access.ToIO(), share.ToIO());
        }

        public bool Exists(string path) {
            return File.Exists(path);
        }

        public void CreateDirectory(string path) {
            Directory.CreateDirectory(path);
        }

        public IDisposable FileLock(string path) {
            return new FileStream(path, IOFileMode.OpenOrCreate, IOFileAccess.Read, IOFileShare.None);
        }

        public void Remove(string path) {
            File.Delete(path);
        }

        public void RemoveDirectory(string path) {
            if (Directory.Exists(path)) {
                Directory.Delete(path, true);
            }
        }

        public void Move(string fromPath, string toPath) {
            File.Move(fromPath, toPath);
        }
    }
}